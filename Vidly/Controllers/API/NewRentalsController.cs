﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTO;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRental)
        {
            //NOTE commented checks are defensive checking
            //if (newRental.MovieIds.Count == 0)
            //    return BadRequest("No Movie Ids");

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            //if (customer == null)
            //    return BadRequest("CustomerId not valid");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            //if (movies.Count != newRental.MovieIds.Count)
            //    return BadRequest("One or more Movie Ids are invalid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);

            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
