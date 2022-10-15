﻿using osu_skin_changer.lib.Validation;
using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Model
{
    public class Skin
    {
        [Required(ErrorMessage = "Name is empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author is empty.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Profile is empty.")]
        public string Profile { get; set; }

        [Required(ErrorMessage = "Version is empty.")]
        public string Version { get; set; }


        [CollectionCompleteness(new string[] {}, typeof(Sound))]
        public FileCollection<Sound> InterfaceSounds { get; set; }


        public Settings Settings { get; set; }

        public Skin() { }
    }
}