using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Validation
{
    public class MediaFileAttribute : ValidationAttribute
    {
        private readonly string[] _allowedExtensions;

        public MediaFileAttribute(string[] allowedExtensions)
        {
            if (allowedExtensions == null || allowedExtensions.Length == 0)
            {
                throw new ArgumentNullException(nameof(allowedExtensions), "Allowed extensions is null or empty.");
            }

            _allowedExtensions = allowedExtensions;
        }

        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                var path = value.ToString();
                if (File.Exists(path))
                {
                    var isValidExtension = false;
                    foreach (var extension in _allowedExtensions)
                    {
                        if (Path.GetExtension(path) == extension)
                        {
                            isValidExtension = true;
                            break;
                        }
                    }
                    
                    if (isValidExtension == true)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = $"File extension is not valid.\nValid extensions: {_allowedExtensions}.";
                    }
                }
                else
                {
                    ErrorMessage = "File is not exist.";
                }
            }
            else
            {
                ErrorMessage = "File is not exist.";
            }

            return false;
        }
    }
}