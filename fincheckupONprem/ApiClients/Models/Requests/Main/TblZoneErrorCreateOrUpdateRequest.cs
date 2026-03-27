using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Main;

public class TblZoneErrorCreateOrUpdateRequest
{
    public DataViewerError DataViewerError { get; set; }
}

public class TblZoneErrorCreateOrUpdateQuery
{
    public TblZoneErrorCreateOrUpdateRequest Request { get; set; }
}
