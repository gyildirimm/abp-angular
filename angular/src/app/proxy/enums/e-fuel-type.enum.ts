import { mapEnumToOptions } from '@abp/ng.core';

export enum eFuelType {
  gasoline = 0,
  diesel = 1,
}

export const eFuelTypeOptions = mapEnumToOptions(eFuelType);
