using System.Collections.Generic;

namespace fincheckup.ApiClients.Models;
public class DashWCapitalCheckMizan
{
    public DashWCapitalCheckMizan()
    {
        mrequestEntry = new List<DashBilancoViewMizan>();

    }
    public List<DashBilancoViewMizan> mrequestEntry { get; set; }

}