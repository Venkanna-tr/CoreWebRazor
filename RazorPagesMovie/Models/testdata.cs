using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models {
    public class Testdata {
        public Testdata () {

        }
        public int Id { get; set; }

        public DateTime Releasedate { get; set; }

    }
}