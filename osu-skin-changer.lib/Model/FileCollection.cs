using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Model
{
    public class FileCollection<T> where T : class
    {
        [Required(ErrorMessage = "Name is empty.")]
        public string Name { get; }
        public IEnumerable<T> Files { get; }

        public FileCollection() { }
    }
}