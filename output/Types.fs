namespace rec OAAPI.Types

type LatestModel = list<LinkedPlaceModel>

type ClassMappingModel =
    { crmClass: Option<string>
      en: Option<string>
      icon: Option<string>
      systemClass: Option<string>
      view: Option<string> }
    ///Creates an instance of ClassMappingModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ClassMappingModel =
        { crmClass = None
          en = None
          icon = None
          systemClass = None
          view = None }

type ContentModel =
    { contact: Option<string>
      imageSized: Option<ContentModelimageSized>
      intro: Option<string>
      legalNotice: Option<string>
      siteName: Option<string> }
    ///Creates an instance of ContentModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ContentModel =
        { contact = None
          imageSized = None
          intro = None
          legalNotice = None
          siteName = None }

type DepictionModel =
    { ``@id``: Option<string>
      license: Option<string>
      title: Option<string>
      url: Option<string> }

type DescriptionModel =
    { value: Option<string> }
    ///Creates an instance of DescriptionModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): DescriptionModel = { value = None }

type FeatureGeoJSON =
    { ``@id``: string
      crmClass: Option<string>
      depictions: Option<list<DepictionModel>>
      description: Option<list<DescriptionModel>>
      links: Option<list<LinkModel>>
      names: Option<list<NamesModel>>
      properties: Option<FeatureGeoJSONproperties>
      relations: Option<list<RelationModel>>
      systemClass: Option<string>
      ``type``: string
      types: Option<list<TypeModel>>
      ``when``: Option<list<WhenModel>> }

type GeometricEntries =
    { features: Option<list<GeometricEntry>>
      ``type``: Option<string> }
    ///Creates an instance of GeometricEntries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): GeometricEntries = { features = None; ``type`` = None }

type GeometricEntry =
    { geometry: Option<GeometricEntrygeometry>
      properties: Option<GeometricEntryproperties>
      ``type``: Option<string> }
    ///Creates an instance of GeometricEntry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): GeometricEntry =
        { geometry = None
          properties = None
          ``type`` = None }

type Geometries =
    { geometry: Option<GeometricEntrygeometry>
      properties: Option<Geometriesproperties>
      ``type``: Option<string> }
    ///Creates an instance of Geometries with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Geometries =
        { geometry = None
          properties = None
          ``type`` = None }

type GeometryModel =
    { features: Option<list<Geometries>>
      ``type``: Option<string> }
    ///Creates an instance of GeometryModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): GeometryModel = { features = None; ``type`` = None }

type LinkModel =
    { identifier: Option<string>
      referenceSystem: Option<string>
      ``type``: Option<string> }
    ///Creates an instance of LinkModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): LinkModel =
        { identifier = None
          referenceSystem = None
          ``type`` = None }

type LinkedPlaceModel =
    { ``@context``: Option<string>
      features: list<FeatureGeoJSON>
      ``type``: string }

type NamesModel =
    { alias: Option<string> }
    ///Creates an instance of NamesModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): NamesModel = { alias = None }

type NodeAllModel =
    { nodes: Option<list<NodeModel>> }
    ///Creates an instance of NodeAllModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): NodeAllModel = { nodes = None }

type NodeCategoryModel =
    { custom: Option<list<string>>
      places: Option<list<string>>
      standard: Option<list<string>>
      value: Option<list<string>> }
    ///Creates an instance of NodeCategoryModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): NodeCategoryModel =
        { custom = None
          places = None
          standard = None
          value = None }

type NodeModel =
    { id: Option<float>
      label: Option<string>
      url: Option<string> }
    ///Creates an instance of NodeModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): NodeModel = { id = None; label = None; url = None }

type NodeOverviewModel =
    { types: Option<list<NodeCategoryModel>> }
    ///Creates an instance of NodeOverviewModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): NodeOverviewModel = { types = None }

type OutputModelGeojson =
    { pagination: Option<PaginationModel>
      results: Option<list<GeometryModel>> }
    ///Creates an instance of OutputModelGeojson with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OutputModelGeojson = { pagination = None; results = None }

type OutputModelLPF =
    { pagination: Option<PaginationModel>
      results: Option<list<LinkedPlaceModel>> }
    ///Creates an instance of OutputModelLPF with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OutputModelLPF = { pagination = None; results = None }

type OverviewCountModel =
    { count: Option<float>
      systemClass: Option<string> }
    ///Creates an instance of OverviewCountModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): OverviewCountModel = { count = None; systemClass = None }

type PaginationIndexModel =
    { page: Option<float>
      startId: Option<float> }
    ///Creates an instance of PaginationIndexModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PaginationIndexModel = { page = None; startId = None }

type PaginationModel =
    { entities: Option<float>
      entitiesPerPage: Option<float>
      index: Option<list<PaginationIndexModel>>
      totalPages: Option<float> }
    ///Creates an instance of PaginationModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PaginationModel =
        { entities = None
          entitiesPerPage = None
          index = None
          totalPages = None }

type RelationModel =
    { label: Option<string>
      relationTo: Option<string>
      relationType: Option<string>
      ``type``: Option<string>
      ``when``: Option<list<WhenModel>> }
    ///Creates an instance of RelationModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): RelationModel =
        { label = None
          relationTo = None
          relationType = None
          ``type`` = None
          ``when`` = None }

type SystemClassCountModel =
    { acquisition: Option<float>
      activity: Option<float>
      administrative_unit: Option<float>
      artifact: Option<float>
      bibliography: Option<float>
      edition: Option<float>
      feature: Option<float>
      file: Option<float>
      group: Option<float>
      move: Option<float>
      person: Option<float>
      place: Option<float>
      reference_system: Option<float>
      source: Option<float>
      source_translation: Option<float>
      stratigraphic_unit: Option<float>
      ``type``: Option<float> }
    ///Creates an instance of SystemClassCountModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): SystemClassCountModel =
        { acquisition = None
          activity = None
          administrative_unit = None
          artifact = None
          bibliography = None
          edition = None
          feature = None
          file = None
          group = None
          move = None
          person = None
          place = None
          reference_system = None
          source = None
          source_translation = None
          stratigraphic_unit = None
          ``type`` = None }

type TimeDetailModel =
    { earliest: Option<string>
      latest: Option<string> }
    ///Creates an instance of TimeDetailModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TimeDetailModel = { earliest = None; latest = None }

type TimespansModel =
    { ``end``: Option<TimeDetailModel>
      first: Option<TimeDetailModel> }
    ///Creates an instance of TimespansModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TimespansModel = { ``end`` = None; first = None }

type TypeModel =
    { hierarchy: Option<string>
      identifier: Option<string>
      label: Option<string> }
    ///Creates an instance of TypeModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TypeModel =
        { hierarchy = None
          identifier = None
          label = None }

type TypeTreeModel =
    { type_tree: Option<list<TypeTreeSubModel>> }
    ///Creates an instance of TypeTreeModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TypeTreeModel = { type_tree = None }

type TypeTreeSubModel =
    { Type_IDs: Option<TypeTreeSubModelTypeIDs> }
    ///Creates an instance of TypeTreeSubModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TypeTreeSubModel = { Type_IDs = None }

type WhenModel =
    { timespans: Option<list<TimespansModel>> }
    ///Creates an instance of WhenModel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WhenModel = { timespans = None }

type ContentModelimageSized =
    { table: Option<string>
      thumbnail: Option<string> }
    ///Creates an instance of ContentModelimageSized with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ContentModelimageSized = { table = None; thumbnail = None }

type FeatureGeoJSONproperties =
    { title: Option<string> }
    ///Creates an instance of FeatureGeoJSONproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): FeatureGeoJSONproperties = { title = None }

type GeometricEntrygeometry =
    { coordinates: Option<list<list<float>>>
      ``type``: Option<string> }
    ///Creates an instance of GeometricEntrygeometry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): GeometricEntrygeometry = { coordinates = None; ``type`` = None }

type GeometricEntryproperties =
    { description: Option<string>
      id: Option<float>
      name: Option<string>
      objectDescription: Option<string>
      objectId: Option<int>
      objectName: Option<string>
      objectType: Option<string>
      shapeType: Option<string> }
    ///Creates an instance of GeometricEntryproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): GeometricEntryproperties =
        { description = None
          id = None
          name = None
          objectDescription = None
          objectId = None
          objectName = None
          objectType = None
          shapeType = None }

type Geometriespropertiesplacetypes =
    { id: Option<float>
      name: Option<string> }
    ///Creates an instance of Geometriespropertiesplacetypes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Geometriespropertiesplacetypes = { id = None; name = None }

type Geometriespropertiesplace =
    { id: Option<float>
      name: Option<string>
      types: Option<list<Geometriespropertiesplacetypes>> }
    ///Creates an instance of Geometriespropertiesplace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Geometriespropertiesplace = { id = None; name = None; types = None }

type Geometriesproperties =
    { begin_from: Option<string>
      begin_to: Option<string>
      description: Option<string>
      end_from: Option<string>
      end_to: Option<string>
      id: Option<float>
      name: Option<string>
      place: Option<Geometriespropertiesplace>
      ``type``: Option<string> }
    ///Creates an instance of Geometriesproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Geometriesproperties =
        { begin_from = None
          begin_to = None
          description = None
          end_from = None
          end_to = None
          id = None
          name = None
          place = None
          ``type`` = None }

type TypeTreeSubModelTypeIDs =
    { count: Option<int>
      count_subs: Option<int>
      description: Option<string>
      first: Option<int>
      id: Option<int>
      last: Option<int>
      locked: Option<bool>
      name: Option<string>
      note: Option<string>
      origin_id: Option<int>
      root: Option<list<int>>
      standard: Option<bool>
      subs: Option<list<int>> }
    ///Creates an instance of TypeTreeSubModelTypeIDs with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): TypeTreeSubModelTypeIDs =
        { count = None
          count_subs = None
          description = None
          first = None
          id = None
          last = None
          locked = None
          name = None
          note = None
          origin_id = None
          root = None
          standard = None
          subs = None }

[<RequireQualifiedAccess>]
type GetApi02ClassByClassCode =
    ///A json with a list of results and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02Classes =
    ///List of all available system classes
    | OK of payload: list<ClassMappingModel>
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02CodeByCode =
    ///A dictionary with a result dictionary and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02Content =
    ///Json of OpenAtlas content (Intro, Legal Notice and Contact)
    | OK of payload: ContentModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02EntitiesLinkedToEntityById =
    ///A dictionary with a result dictionary and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02EntityById =
    ///A geojson representation of the specified entity
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02GeometricEntities =
    ///Only places with geometries will retrieved.
    | OK of payload: GeometricEntries
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02LatestByLatest =
    ///A json with a result list and pagination information
    | OK of payload: list<LinkedPlaceModel>
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02NodeEntitiesById =
    ///A list of node entities linked to the given node
    | OK of payload: NodeAllModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02NodeEntitiesAllById =
    ///A list of node entities linked to the given node
    | OK of payload: NodeAllModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02NodeOverview =
    ///A list of all types
    | OK of payload: NodeOverviewModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02OverviewCount =
    ///Count of all entities
    | OK of payload: OverviewCountModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02Query =
    ///A dictionary with a result dictionary and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02SubunitById =
    ///A list of node entities linked to the given node
    | OK of payload: NodeAllModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02SubunitHierarchyById =
    ///A list of node entities linked to the given node
    | OK of payload: NodeAllModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02SystemClassBySystemClass =
    ///A dictionary with a result dictionary and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02SystemClassCount =
    ///Count of all entities
    | OK of payload: SystemClassCountModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02TypeEntitiesById =
    ///A dictionary with a result dictionary and pagination information
    | OK
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02TypeEntitiesAllById =
    ///A dictionary with a result dictionary and pagination information
    | OK of payload: TypeTreeModel
    ///Something went wrong. Please consult the error message.
    | NotFound

[<RequireQualifiedAccess>]
type GetApi02TypeTree =
    ///List of all *Types*
    | OK of payload: TypeTreeModel
    ///Something went wrong. Please consult the error message.
    | NotFound
