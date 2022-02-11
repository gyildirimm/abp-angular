import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpAngularExample',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44382',
    redirectUri: baseUrl,
    clientId: 'AbpAngularExample_App',
    dummyClientSecret: '1q2w3e*',
    responseType: 'code',
    scope: 'offline_access AbpAngularExample',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44382',
      rootNamespace: 'AbpAngularExample',
    },
  },
} as Environment;
