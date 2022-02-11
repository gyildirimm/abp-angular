import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CarDto } from '@proxy/dtos/cars';
import { CarService } from '@proxy/services/car.service';

import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // add this
import { eFuelTypeOptions } from '@proxy/enums';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';


import { ModelDto } from '@proxy/dtos/models';
import { ModelService } from '@proxy/services';



@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.scss'],
  providers:[
    ListService,
    { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class CarComponent implements OnInit {

  car = { items: [], totalCount: 0 } as PagedResultDto<CarDto>;
  carFuelType = eFuelTypeOptions;
  
 selectedCar = {} as CarDto;

  models: ModelDto[];


  form: FormGroup;
  isModalOpen = false; 

  constructor(
    public readonly list: ListService,
     private carService: CarService,
     private modelService: ModelService,
     private fb: FormBuilder,
     private confirmation: ConfirmationService
     ) {}


  ngOnInit(): void {
    const bookStreamCreator = (query) => this.carService.getDetailsByFilterByFilter(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.car = response;
    });
  }

  createCar() {
    this.selectedCar = {} as CarDto;
    this.fillModels();
    this.buildForm();
    this.isModalOpen = true;
  }

  editCar(id: number) {
    this.fillModels();
    this.carService.get(id).subscribe((car) => {
      this.selectedCar = car;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm() {
    console.log(this.selectedCar);
    console.log(this.carFuelType);
    this.form = this.fb.group({
      id: [this.selectedCar.id || 0],
      title: [this.selectedCar.title || '', Validators.required],
      modelId: [this.selectedCar.modelID || 0, Validators.required],
      fuelType: [this.selectedCar.fuelType, Validators.required],
      year: [this.selectedCar.year || null, Validators.required],
      purchaseDate: [this.selectedCar.purchaseDate ? new Date(this.selectedCar.purchaseDate) : null, Validators.required],
      invoiceAmount: [this.selectedCar.invoiceAmount ||null, Validators.required],
    });
  }

  save(){
    if(this.form.invalid) {
      return;
    }

    const request = this.selectedCar.id
    ? this.carService.update(this.selectedCar.id, this.form.value)
    : this.carService.create(this.form.value);


    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    })
  }

  fillModels() {
    const modelStramCreator = () => this.modelService.getFull();

    modelStramCreator().subscribe((response) => {
      this.models = response;
    });
  }

  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.carService.delete(id).subscribe(() => this.list.get());
      }
    });
  }


}
