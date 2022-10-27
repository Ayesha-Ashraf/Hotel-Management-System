using Hotel_Management_System.Model;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Hotel_Management_System.Services
{
    public class jsonfileroomServices
    {
        // Json -> Program
        // Need a vraiable for home/root address & then generate file address & then do file handling

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // Set Actual Hosting Environment  E.g: [Here We don't know the environment](?) / Our file name
        public jsonfileroomServices(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Generate File Address
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "room.json");
            }
        }

        // File Handling
        public IEnumerable<room> getroomRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<room[]>(filestream.ReadToEnd());
            }
        }
    }
}

