import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { ModelCreateDto, ModelDto, ModelUpdateDto } from '../dtos/models/models';

@Injectable({
  providedIn: 'root',
})
export class ModelService {
  apiName = 'Default';

  create = (input: ModelCreateDto) =>
    this.restService.request<any, ModelDto>({
      method: 'POST',
      url: '/api/app/model',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: number) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/model/${id}`,
    },
    { apiName: this.apiName });

  get = (id: number) =>
    this.restService.request<any, ModelDto>({
      method: 'GET',
      url: `/api/app/model/${id}`,
    },
    { apiName: this.apiName });

  getAllDetails = () =>
    this.restService.request<any, ModelDto[]>({
      method: 'GET',
      url: '/api/app/model/details',
    },
    { apiName: this.apiName });

  getByBrandIdByBrandId = (brandId: number) =>
    this.restService.request<any, ModelDto[]>({
      method: 'GET',
      url: `/api/app/model/by-brand-id/${brandId}`,
    },
    { apiName: this.apiName });

  getDetailsByFilterByFilter = (filter: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ModelDto>>({
      method: 'GET',
      url: '/api/app/model/details-by-filter',
      params: { skipCount: filter.skipCount, maxResultCount: filter.maxResultCount, sorting: filter.sorting },
    },
    { apiName: this.apiName });

  getFull = () =>
    this.restService.request<any, ModelDto[]>({
      method: 'GET',
      url: '/api/app/model/full',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ModelDto>>({
      method: 'GET',
      url: '/api/app/model',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: number, input: ModelUpdateDto) =>
    this.restService.request<any, ModelDto>({
      method: 'PUT',
      url: `/api/app/model/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
