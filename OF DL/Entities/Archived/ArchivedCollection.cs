namespace OF_DL.Entities.Archived
{
    public class ArchivedCollection
    {
        public Dictionary<long, string> ArchivedPosts = new Dictionary<long, string>();
        public List<Archived.List> ArchivedPostObjects = new List<Archived.List>();
        public List<Archived.Medium> ArchivedPostMedia = new List<Archived.Medium>();
    }
}
