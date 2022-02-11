import type { EntityDto } from '@abp/ng.core';

export interface BrandCreateDto {
  name?: string;
}

export interface BrandDto extends EntityDto<number> {
  name?: string;
}

export interface BrandUpdateDto extends EntityDto<number> {
  name?: string;
}
