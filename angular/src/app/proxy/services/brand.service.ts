import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { BrandCreateDto, BrandDto, BrandUpdateDto } from '../dtos/brands/models';

@Injectable({
  providedIn: 'root',
})
export class BrandService {
  apiName = 'Default';

  create = (input: BrandCreateDto) =>
    this.restService.request<any, BrandDto>({
      method: 'POST',
      url: '/api/app/brand',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: number) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/brand/${id}`,
    },
    { apiName: this.apiName });

  get = (id: number) =>
    this.restService.request<any, BrandDto>({
      method: 'GET',
      url: `/api/app/brand/${id}`,
    },
    { apiName: this.apiName });

  getAllDetails = () =>
    this.restService.request<any, BrandDto[]>({
      method: 'GET',
      url: '/api/app/brand/details',
    },
    { apiName: this.apiName });

  getDetailsByFilterByFilter = (filter: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<BrandDto>>({
      method: 'GET',
      url: '/api/app/brand/details-by-filter',
      params: { skipCount: filter.skipCount, maxResultCount: filter.maxResultCount, sorting: filter.sorting },
    },
    { apiName: this.apiName });

  getFull = () =>
    this.restService.request<any, BrandDto[]>({
      method: 'GET',
      url: '/api/app/brand/full',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<BrandDto>>({
      method: 'GET',
      url: '/api/app/brand',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: number, input: BrandUpdateDto) =>
    this.restService.request<any, BrandDto>({
      method: 'PUT',
      url: `/api/app/brand/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
