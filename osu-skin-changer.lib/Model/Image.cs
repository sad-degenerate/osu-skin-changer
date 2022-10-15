using osu_skin_changer.lib.Validation;
using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Model
{
    public class Image : BaseObject
    {
        [Required(ErrorMessage = "Name is empty.")]
        public override string Name { get; }

        [MediaFile(new string[] { ".png" })]
        public override string FilePath { get; }

        public Image() { }
    }
}