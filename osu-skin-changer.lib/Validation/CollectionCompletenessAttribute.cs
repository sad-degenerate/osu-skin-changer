using osu_skin_changer.lib.Model;
using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Validation
{
    public class CollectionCompletenessAttribute : ValidationAttribute
    {
        private readonly string[] _expectedContent;
        private readonly Type _type;
        public CollectionCompletenessAttribute(string[] expectedContent, Type type)
        {
            if (expectedContent == null || expectedContent.Length == 0)
            {
                throw new ArgumentNullException(nameof(expectedContent), "Expected content is empty.");
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type), "Type is null.");
            }

            _expectedContent = expectedContent;
            _type = type;
        }

        public override bool IsValid(object? value)
        {
            if (_type == typeof(Sound))
            {
                if (CompareContents(value as IEnumerable<Sound>) == false)
                {
                    ErrorMessage = "Collection content is not including expected content.";
                    return false;
                }
            }
            else if (_type == typeof(Image))
            {
                if (CompareContents(value as IEnumerable<Image>) == false)
                {
                    ErrorMessage = "Collection content is not including expected content.";
                    return false;
                }
            }
            else
            {
                ErrorMessage = "Collection type is not allowed.";
                return false;
            }

            return true;
        }

        private bool CompareContents<T>(IEnumerable<T> collection) where T : BaseObject
        {
            foreach (var expectedContent in _expectedContent)
            {
                var isContentExists = false;
                foreach (var content in collection)
                {
                    if (content.Name == expectedContent)
                    {
                        isContentExists = true;
                        break;
                    }
                }
                
                if (isContentExists == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}