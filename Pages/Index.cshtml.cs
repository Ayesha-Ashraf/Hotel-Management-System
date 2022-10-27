using Hotel_Management_System.Model;
using Hotel_Management_System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Hotel_Management_System.Pages
{
    public class IndexModel : PageModel
    {

        // Need variable for service
        jsonfileroomServices roomService;

        // Need variable for room Record
        public IEnumerable<room> rooms;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, jsonfileroomServices service)
        {
            _logger = logger;
            roomService = service;
        }

        public void OnGet()
        {
            rooms = roomService.getroomRecord();
        }
    }
}
