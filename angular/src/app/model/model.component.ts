import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto  } from '@abp/ng.core';

import { ModelService } from '@proxy/services/model.service';
import { ModelDto } from '@proxy/dtos/models';
import { BrandDto } from '@proxy/dtos/brands';
import { BrandService } from '@proxy/services';

import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';



@Component({
  selector: 'app-model',
  templateUrl: './model.component.html',
  styleUrls: ['./model.component.scss'],
  providers: [ListService]
})
export class ModelComponent implements OnInit {

  model = { items: [], totalCount: 0 } as PagedResultDto<ModelDto>;

  brands: BrandDto[];

  selectedModel = {} as ModelDto;

  form: FormGroup;

  isModalOpen = false;

  constructor(
    private readonly list: ListService, 
    private modelService : ModelService,
    private fb: FormBuilder,
    private brandService: BrandService,
    private confirmation: ConfirmationService
  ) { }

  ngOnInit(): void {
    const modelStramCreator = (query) => this.modelService.getDetailsByFilterByFilter(query);

    this.list.hookToQuery(modelStramCreator).subscribe((response) => {
      this.model = response;
    });
  }

  createModel() {
    this.selectedModel = {} as ModelDto;
    this.fillBrands();
    this.buildForm();
    this.isModalOpen = true;
  }

  editModel(id: number) {
    this.fillBrands();
    this.modelService.get(id).subscribe((model) => {
      this.selectedModel = model;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.modelService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      id: [this.selectedModel.id || 0],
      name: [this.selectedModel.name || '', Validators.required],
      brandId: [this.selectedModel.brandID || 0, Validators.required]
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }


    const request = this.selectedModel.id
      ? this.modelService.update(this.selectedModel.id, this.form.value)
      : this.modelService.create(this.form.value);

      request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

  fillBrands() {
    const brandStramCreator = () => this.brandService.getFull();

    brandStramCreator().subscribe((response) => {
      this.brands = response;
    });
  }

}

