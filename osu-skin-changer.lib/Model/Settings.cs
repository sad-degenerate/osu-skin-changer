using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace osu_skin_changer.lib.Model
{
    public class Settings
    {
        [Required(ErrorMessage = "Animation frame rate is empty.")]
        public int AnimationFramerate { get; }


        [Required(ErrorMessage = "Cursor rotate is empty.")]
        public bool CursorRotate { get; }
        [Required(ErrorMessage = "Cursor expand is empty.")]
        public bool CursorExpand { get; }
        [Required(ErrorMessage = "Cursor center is empty.")]
        public bool CursorCenter { get; }

        // TODO: Check empty collection causes.

        [Required(ErrorMessage = "Combo colors are empty.")]
        public IEnumerable<Color> ComboColors { get; }

        [Required(ErrorMessage = "Score prefix is empty.")]
        public string ScorePrefix { get; set; }
        [Required(ErrorMessage = "Combo prefix is empty.")]
        public string ComboPrefix { get; set; }
        [Required(ErrorMessage = "Default prefix is empty.")]
        public string DefaultPrefix { get; set; }

        [Required(ErrorMessage = "Score overlap is empty.")]
        public string ScoreOverlap { get; set; }
        [Required(ErrorMessage = "Combo overlap is empty.")]
        public string ComboOverlap { get; set; }
        [Required(ErrorMessage = "Default overlap is empty.")]
        public string DefaultOverlap { get; set; }
    }
}