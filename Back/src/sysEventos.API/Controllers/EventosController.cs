using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sysEventos.API.Models;

namespace sysEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Eventos> _eventos = new Eventos[]
            {
                new Eventos()
                {
                    EventoId = 1,
                    Local = "Fortaleza",
                    DataEvento = "12/04/2022",
                    Tema =  "ASPNetCore e Angular",
                    QntPessoas = 3400,
                    Lote = "1º",
                    ImagemURL = "foto1.png"
                },
                new Eventos()
                {
                    EventoId = 2,
                    Local = "São Paulo",
                    DataEvento = "05/07/2022",
                    Tema =  "WebApi",
                    QntPessoas = 2400,
                    Lote = "2º",
                    ImagemURL = "foto2.png"
                }
                
            };

        public EventosController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _eventos;
           
        }
         [HttpGet("{id}")]
        public IEnumerable<Eventos> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
           
        }
    }
}
