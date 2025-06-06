# Release History

## 1.7.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.6.0 (2025-06-10)

### Features Added
- Updated service API version to use API version 2023-10-31 by default.

### Breaking changes

- Renamed tags reported on `DigitalTwinsClient` activities to follow OpenTelemetry attribute naming conventions:
  - `digitalTwinId` to `az.digitaltwins.twin.id`
  - `componentName` to `az.digitaltwins.component.name`
  - `relationshipName` to `az.digitaltwins.relationship.name`
  - `modelId` to `az.digitaltwins.model.id`
  - `jobId` to `az.digitaltwins.job.id`
  - `query` to `az.digitaltwins.query`
  - `eventRouteId` to `az.digitaltwins.event_route.id`
  - `messageId` to `az.digitaltwins.message.id`

## 1.5.0 (2023-09-07)

### Features Added
- Updated service API version to use API version 2023-06-30 by default.
- Added support for the new import job. You can now use a blob file in your storage account to import multiple models, twins and relationships at once.

## 1.4.0 (2022-06-30)

### Features Added

- Updated service API version to use API version 2022-05-31 by default.
- Added support for the new, writeable property metadata `SourceTime` to `DigitalTwinPropertyMetadata`.
- Added support for `LastUpdatedOn` for digital twins and components.

### Fixes and improvements

- Updated samples to illustrate usage of `SourceTime`, `LastUpdatedOn` at digital twin and component metadata level, and use of `DigitalTwinComponentMetadata`.

## 1.2.2 (2021-04-12)

### Fixes and improvements

- Updated core dependencies to bring in security vulnerability fixes that are addressed in `Azure.Core v1.13.0` and `System.Memory.Data v1.0.2`

## 1.2.1 (2021-02-03)

### Fixes and improvements

- Fixed an issue with Query APIs when `DigitalTwinsClient` has been initialized with a non-default `ObjectSerializer`.

## 1.2.0 (2020-11-16)

### Features Added

- Added `DigitalTwinsModelFactory` to allow for the creation of certain model objects to enable mocking them for unit tests.

### Breaking changes

- None

### Fixes and improvements

- None

## 1.0.1 (2020-11-04)

### Fixes and improvements

- Improved deserialization and error reporting for `BasicDigitalTwin` for `DigitalTwinMetadata`.
- Removed logic to determine authorization scope based on digital twins instance URI.

## 1.0.0 (2020-10-30)

### Features Added

- Regenerated protocol layer from service API version 2020-10-31.
- Updated service API version to use service API version 2020-10-31 by default.

### Breaking changes

Note that these breaking changes are only breaking changes from the **preview** version of this library.

- Replaced all `Response<string>` and `Pageable<string>` APIs with `Response<T>` and `Pageable<T>` respectively.
- Renamed `CreateDigitalTwin`, `CreateRelationship` and `CreateEventRoute` APIs to `CreateOrReplaceDigitalTwin`, `CreateOrReplaceRelationship` and `CreateOrReplaceEventRoute` respectively.
- Renamed model type `ModelData` to `DigitalTwinsModelData` to make type less generic, and less likely to conflict with other libraries.
- Renamed model type `EventRoute` to `DigitalTwinsEventRoute` to make type less generic, and less likely to conflict with other libraries.
- `EventRoute` (now `DigitalTwinsEventRoute`) object ctor now requires filter.
- Removed `UpdateOperationsUtility` and replace it with a direct dependency on [JsonPatchDocument](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/src/JsonPatchDocument.cs) from Azure.Core.
- Removed `WritableProperty` since service no longer returns that type.
- Removed `MaxItemCount` parameter as an option for `GetEventRoutes` APIs since users are expected to provide page size in pageable type's .AsPages() method instead.
- Removed Serialization namespace, moving its contents to the base Azure.DigitalTwins.Core namespace.
- Renamed `DigitalTwinsModelData` field `DisplayName` to `LanguageDisplayNames` for clarity.
- Renamed `DigitalTwinsModelData` field `Description` to `LanguageDescriptions` for clarity.
- Renamed `DigitalTwinsModelData` field `model` to `dtdlModel`.
- Flattened `DigitalTwinsRequestOptions` so that each API takes in `ifMatch` and `ifNoneMatch` header directly.
- Reworked `BasicDigitalTwin` and other helper classes to better match the service definitions. This includes renaming `CustomProperties` to `Contents`.
- Added `messageId` as mandatory parameter for telemetry APIs. Service API version 2020-10-31 requires this parameter.
- Renamed `CreateModels` API parameter `models` to `dtdtlModels` for clarity.
- Reworked `GetModels` APIs to take options bundle rather than take individual options.

### Fixes and improvements

- Fixed bug where `CreateDigitalTwin` and `CreateRelationship` APIs always sent ifNoneMatch header with value "*" making it impossible to replace an existing entity.
- Fixed authentication scope for ADT instances that don't match the public cloud domain name pattern.

## 1.0.0-preview.3 (2020-07-13)

### Breaking changes

- Type definitions in Azure.DigitalTwins.Core.Models namespace moved to Azure.DigitalTwins.Core.
- `CreateModelsAsync` and `CreateModels` APIs now return `Response<ModelData[]>` instead of `Response<IReadOnlyList<ModelData>>`.

## 1.0.0-preview.2 

### New features

- Official public preview of [Azure.DigitalTwins.Core SDK](https://www.nuget.org/packages/Azure.DigitalTwins.Core)
- [Azure Digital Twins Public Repo](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/digitaltwins/Azure.DigitalTwins.Core)
- [Azure Digital Twins Samples](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/digitaltwins/Azure.DigitalTwins.Core/samples)

