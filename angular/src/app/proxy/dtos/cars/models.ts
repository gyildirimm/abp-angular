import type { eFuelType } from '../../enums/e-fuel-type.enum';
import type { EntityDto } from '@abp/ng.core';
import type { ModelDto } from '../models/models';

export interface CarCreateDto {
  title?: string;
  modelId: number;
  fuelType: eFuelType;
  year: number;
  purchaseDate?: string;
  invoiceAmount: number;
}

export interface CarDto extends EntityDto<number> {
  title?: string;
  model: ModelDto;
  modelID: number;
  fuelType: eFuelType;
  year: number;
  purchaseDate?: string;
  invoiceAmount: number;
}

export interface CarUpdateDto extends EntityDto<number> {
  title?: string;
  modelId: number;
  fuelType: eFuelType;
  year: number;
  purchaseDate?: string;
  invoiceAmount: number;
}
