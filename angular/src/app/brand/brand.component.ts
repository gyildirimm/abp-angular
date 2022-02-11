import { ListService, PagedResultDto} from '@abp/ng.core'
import { Component, OnInit } from '@angular/core';

import { BrandService } from '@proxy/services';
import { BrandDto } from '@proxy/dtos/brands';

import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';


@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.scss'],
  providers: [ListService]
})
export class BrandComponent implements OnInit {
  brand = { items: [], totalCount: 0 } as PagedResultDto<BrandDto>;

  selectedBrand = {} as BrandDto;


  form: FormGroup;

  isModalOpen = false;

  constructor(
    public readonly list: ListService, 
    private brandService : BrandService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
    ) { }

  ngOnInit(): void {
    const brandStreamCreator = (query) => this.brandService.getList(query);

    this.list.hookToQuery(brandStreamCreator).subscribe((response) => {
      this.brand = response;
    });
  }

  createBrand() {
    this.selectedBrand = {} as BrandDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editBrand(id: number) {
    this.brandService.get(id).subscribe((brand) => {
      this.selectedBrand = brand;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.brandService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm(){
    this.form = this.fb.group({
      id: [this.selectedBrand.id || 0],
      name: [this.selectedBrand.name || '', Validators.required]
    });
  }

  save() {
    if(this.form.invalid) {
      return;
    }

    const request = this.selectedBrand.id 
                ? this.brandService.update(this.selectedBrand.id, this.form.value)
                : this.brandService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });

  }

}
