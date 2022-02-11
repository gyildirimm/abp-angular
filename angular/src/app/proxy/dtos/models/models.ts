import type { EntityDto } from '@abp/ng.core';
import type { BrandDto } from '../brands/models';

export interface ModelDto extends EntityDto<number> {
  name?: string;
  brandID: number;
  brand: BrandDto;
}

export interface ModelCreateDto {
  name?: string;
  brandId: number;
}

export interface ModelUpdateDto extends EntityDto<number> {
  name?: string;
  brandId: number;
}
