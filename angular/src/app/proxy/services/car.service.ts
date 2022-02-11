import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CarCreateDto, CarDto, CarUpdateDto } from '../dtos/cars/models';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  apiName = 'Default';

  create = (input: CarCreateDto) =>
    this.restService.request<any, CarDto>({
      method: 'POST',
      url: '/api/app/car',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: number) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/car/${id}`,
    },
    { apiName: this.apiName });

  get = (id: number) =>
    this.restService.request<any, CarDto>({
      method: 'GET',
      url: `/api/app/car/${id}`,
    },
    { apiName: this.apiName });

  getAllDetails = () =>
    this.restService.request<any, CarDto[]>({
      method: 'GET',
      url: '/api/app/car/details',
    },
    { apiName: this.apiName });

  getDetailsByFilterByFilter = (filter: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<CarDto>>({
      method: 'GET',
      url: '/api/app/car/details-by-filter',
      params: { skipCount: filter.skipCount, maxResultCount: filter.maxResultCount, sorting: filter.sorting },
    },
    { apiName: this.apiName });

  getFull = () =>
    this.restService.request<any, CarDto[]>({
      method: 'GET',
      url: '/api/app/car/full',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<CarDto>>({
      method: 'GET',
      url: '/api/app/car',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: number, input: CarUpdateDto) =>
    this.restService.request<any, CarDto>({
      method: 'PUT',
      url: `/api/app/car/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
