using osu_skin_changer.lib.Validation;
using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Model
{
    public class Sound : BaseObject
    {
        [Required(ErrorMessage = "Name is empty.")]
        public override string Name { get; }

        [MediaFile(new string[] { ".mp3", ".ogg", ".waw" })]
        public override string FilePath { get; }

        public Sound() { }
    }
}