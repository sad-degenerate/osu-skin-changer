using osu_skin_changer.lib.Model;

namespace osu_skin_changer.lib.Validation
{
    public static class CollectionCompleteness<T> where T : BaseObject
    {
        public static bool IsCollectionCompleteness(FileCollection<T> collection, string[] expectedContent)
        {
            foreach (var content in expectedContent)
            {
                var isContentExists = false;
                foreach (var item in collection.Files)
                {
                    if (item.Name == content)
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