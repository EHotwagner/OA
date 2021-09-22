namespace rec OAAPI

open System.Net
open System.Net.Http
open System.Text
open OAAPI.Types
open OAAPI.Http

///A documentation of the OpenAtlas API
type OAAPIClient(httpClient: HttpClient) =
    ///<summary>
    ///Retrieves a json with a list of entities based on their CIDOC CRM class code. The json contains a **result** and **pagination** key. All in OpenAtlas available codes can be found under `https://redmine.craws.net/projects/uni/wiki/OpenAtlas_and_CIDOC_CRM_class_mapping`. The result can also be filtered, ordered and manipulated through different parameters. By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="classCode">Need to be a valid CIDOC CRM class code (e.g. E21, E18, E33)</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02ClassByClassCode
        (
            classCode: string,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ RequestPart.path ("class_code", classCode)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/class/{class_code}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02ClassByClassCode.OK
        else
            GetApi02ClassByClassCode.NotFound

    ///<summary>
    ///Provides a list of all available system classes, their CIDOC CRM mapping, which view they belong, which icon is used and the englisch name
    ///</summary>
    member this.GetApi02Classes() =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/classes/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02Classes.OK(Serializer.deserialize content)
        else
            GetApi02Classes.NotFound

    ///<summary>
    ///Retrieves a json with a list of entities based on their OpenAtlas categorie. Available categories are **actor**, **event**, **place**, **source**, **reference**, **object**. The result can also be filtered, ordered and manipulated through different parameters. By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="code">Need to be an OpenAtlas menu item</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02CodeByCode
        (
            code: string,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ RequestPart.path ("code", code)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/code/{code}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02CodeByCode.OK
        else
            GetApi02CodeByCode.NotFound

    ///<summary>
    ///Retrieves a json of the content (Intro, Legal Notice, Contact and the size for processed images) from the OpenAtlas instance. The language can be choosen with the **lang** parameter (en or de).
    ///</summary>
    ///<param name="language">Select output language</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02Content(?language: string, ?download: bool) =
        let requestParts =
            [ if language.IsSome then
                  RequestPart.query ("language", language.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/content/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02Content.OK(Serializer.deserialize content)
        else
            GetApi02Content.NotFound

    ///<summary>
    ///Retrieves a json with a list of entities, which are linked to the entered entity. The result can also be filtered, ordered and manipulated through different parameters. By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="id">ID must be an entity</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02EntitiesLinkedToEntityById
        (
            id: float,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool
        ) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/entities_linked_to_entity/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02EntitiesLinkedToEntityById.OK
        else
            GetApi02EntitiesLinkedToEntityById.NotFound

    ///<summary>
    ///Retrieves a geojson representations of an entity through the **id**.
    ///</summary>
    ///<param name="id">Specific entity ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="export">Select to which format the output is downloaded</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02EntityById(id: float, ?show: string, ?download: bool, ?export: string, ?format: string) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if export.IsSome then
                  RequestPart.query ("export", export.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/entity/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02EntityById.OK
        else
            GetApi02EntityById.NotFound

    ///<summary>
    ///Retrieves a list of all selected geometries in the database in a standard Geojson format. This is implimentended for map usage.
    ///</summary>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02GeometricEntities(?count: bool, ?download: bool) =
        let requestParts =
            [ if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/geometric_entities/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02GeometricEntities.OK(Serializer.deserialize content)
        else
            GetApi02GeometricEntities.NotFound

    ///<summary>
    ///Retrieves a json of latest entries made in the OpenAtlas database. The number **latest** represents the amount of entities retrieved. **latest** can be any number between and including 1 and 100. The pagination information is alway `null`
    ///</summary>
    ///<param name="latest">The amount of last enterd entities to be retrieved (Valid numbers between and including 1 and 100)</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02LatestByLatest(latest: float, ?show: string, ?download: bool, ?format: string) =
        let requestParts =
            [ RequestPart.path ("latest", latest)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/latest/{latest}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02LatestByLatest.OK(Serializer.deserialize content)
        else
            GetApi02LatestByLatest.NotFound

    ///<summary>
    ///Retrieves a json list of all entities directly linked to one specific node.
    ///</summary>
    ///<param name="id">The ID of an entity, which has to be a node</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02NodeEntitiesById(id: float, ?count: bool, ?download: bool) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/node_entities/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02NodeEntitiesById.OK(Serializer.deserialize content)
        else
            GetApi02NodeEntitiesById.NotFound

    ///<summary>
    ///Retrieves a json list of all entities linked to a specific node. This path also include all sub entities.
    ///</summary>
    ///<param name="id">The ID of an entity, which has to be a node</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02NodeEntitiesAllById(id: float, ?count: bool, ?download: bool) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/node_entities_all/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02NodeEntitiesAllById.OK(Serializer.deserialize content)
        else
            GetApi02NodeEntitiesAllById.NotFound

    ///<summary>
    ///Retrieves a json list of all types
    ///</summary>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02NodeOverview(?download: bool) =
        let requestParts =
            [ if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/node_overview/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02NodeOverview.OK(Serializer.deserialize content)
        else
            GetApi02NodeOverview.NotFound

    ///<summary>
    ///Retrieves a list of Geojson representations by entity id, CIDOC CRM code or menu item
    ///</summary>
    ///<param name="entities">Specific entity ID</param>
    ///<param name="classes">Need to be a entity class code of the CIDOC CRM (e.g. E21, E18, E33). For further information visit https://redmine.craws.net/projects/uni/wiki/OpenAtlas_and_CIDOC_CRM_class_mapping</param>
    ///<param name="codes">Need to be an OpenAtlas menu items</param>
    ///<param name="systemClasses">Need to be an OpenAtlas system class</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02Query
        (
            ?entities: float,
            ?classes: string,
            ?codes: string,
            ?systemClasses: string,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ if entities.IsSome then
                  RequestPart.query ("entities", entities.Value)
              if classes.IsSome then
                  RequestPart.query ("classes", classes.Value)
              if codes.IsSome then
                  RequestPart.query ("codes", codes.Value)
              if systemClasses.IsSome then
                  RequestPart.query ("system_classes", systemClasses.Value)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/query/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02Query.OK
        else
            GetApi02Query.NotFound

    ///<summary>
    ///Todo
    ///</summary>
    ///<param name="id">The ID of an entity, which has to be a node</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02SubunitById(id: float, ?count: bool, ?download: bool) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/subunit/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02SubunitById.OK(Serializer.deserialize content)
        else
            GetApi02SubunitById.NotFound

    ///<summary>
    ///Todo
    ///</summary>
    ///<param name="id">The ID of an entity, which has to be a node</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02SubunitHierarchyById(id: float, ?count: bool, ?download: bool) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/subunit_hierarchy/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02SubunitHierarchyById.OK(Serializer.deserialize content)
        else
            GetApi02SubunitHierarchyById.NotFound

    ///<summary>
    ///Retrieves a json with a list of entities based on their OpenAtlas system class. Available categories are **acquisition**, **activity**, **actor_appellation**, **administrative_unit**, **appellation**, **artifact**, **bibliography**, **edition**, **external_reference**, **feature**, **file**, **find**, **group**, **human_remains**, **move**, **object_location**, **person**, **place**, **source**, **reference_system**, **stratigraphic_unit**, **source_translation**, **type**,  The result can also be filtered, ordered and manipulated through different parameters.  By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="systemClass">Need to be an OpenAtlas system class</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02SystemClassBySystemClass
        (
            systemClass: string,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ RequestPart.path ("system_class", systemClass)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/system_class/{system_class}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02SystemClassBySystemClass.OK
        else
            GetApi02SystemClassBySystemClass.NotFound

    ///<summary>
    ///System Class Count endpoint
    ///</summary>
    member this.GetApi02SystemClassCount() =
        let requestParts = []

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/system_class_count/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02SystemClassCount.OK(Serializer.deserialize content)
        else
            GetApi02SystemClassCount.NotFound

    ///<summary>
    ///Retrieves a json with a list of entities based on their OpenAtlas type. A possible *id* can be obtained by the *type_tree* or *node_overview* endpoint. The result can also be filtered, ordered and manipulated through different parameters. By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="id">Has to be a OpenAtlas type</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02TypeEntitiesById
        (
            id: float,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/type_entities/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02TypeEntitiesById.OK
        else
            GetApi02TypeEntitiesById.NotFound

    ///<summary>
    ///Retrieves a json with a list of entities based on their OpenAtlas type. This endpoint also includes all entities, which are connected to an subtype. A possible *id* can be obtained by the *type_tree* or *node_overview* endpoint. The result can also be filtered, ordered and manipulated through different parameters. By default results are orderd alphabetically and 20 entities are shown.
    ///</summary>
    ///<param name="id">Has to be a OpenAtlas type</param>
    ///<param name="limit">Number of entities returned per page</param>
    ///<param name="column">The result will be sorted by the given column</param>
    ///<param name="sort">Result will be sorted asc/desc (default column is name)</param>
    ///<param name="filter">Specify request with custom SQL filter method. </param>
    ///<param name="first">List of results start with given ID</param>
    ///<param name="last">List of results start with entity after given ID</param>
    ///<param name="show">Select which key should be shown. If 'not' is used, no other keys will be shown</param>
    ///<param name="typeId">The output will be filtered by the type_id. Only entities with this type ids will be display. The relation is in logical OR.</param>
    ///<param name="count">Returns a number which represents the total count of the result</param>
    ///<param name="download">Triggers the file download of the given request</param>
    ///<param name="format">Select to which output format is prefered</param>
    member this.GetApi02TypeEntitiesAllById
        (
            id: float,
            ?limit: float,
            ?column: string,
            ?sort: string,
            ?filter: string,
            ?first: float,
            ?last: float,
            ?show: string,
            ?typeId: float,
            ?count: bool,
            ?download: bool,
            ?format: string
        ) =
        let requestParts =
            [ RequestPart.path ("id_", id)
              if limit.IsSome then
                  RequestPart.query ("limit", limit.Value)
              if column.IsSome then
                  RequestPart.query ("column", column.Value)
              if sort.IsSome then
                  RequestPart.query ("sort", sort.Value)
              if filter.IsSome then
                  RequestPart.query ("filter", filter.Value)
              if first.IsSome then
                  RequestPart.query ("first", first.Value)
              if last.IsSome then
                  RequestPart.query ("last", last.Value)
              if show.IsSome then
                  RequestPart.query ("show", show.Value)
              if typeId.IsSome then
                  RequestPart.query ("type_id", typeId.Value)
              if count.IsSome then
                  RequestPart.query ("count", count.Value)
              if download.IsSome then
                  RequestPart.query ("download", download.Value)
              if format.IsSome then
                  RequestPart.query ("format", format.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/type_entities_all/{id_}" requestParts

        if status = HttpStatusCode.OK then
            GetApi02TypeEntitiesAllById.OK(Serializer.deserialize content)
        else
            GetApi02TypeEntitiesAllById.NotFound

    ///<summary>
    ///Shows every *Type* in the OA instance, with its root and subs, so a tree can be build
    ///</summary>
    ///<param name="download">Triggers the file download of the given request</param>
    member this.GetApi02TypeTree(?download: bool) =
        let requestParts =
            [ if download.IsSome then
                  RequestPart.query ("download", download.Value) ]

        let (status, content) =
            OpenApiHttp.get httpClient "/api/0.2/type_tree/" requestParts

        if status = HttpStatusCode.OK then
            GetApi02TypeTree.OK(Serializer.deserialize content)
        else
            GetApi02TypeTree.NotFound
