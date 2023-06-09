﻿namespace CMDB_BackEnd.Domain.Data
{
    public class MediaType
    {
        public int Media_TypeId { get; private set; }
        public string Media_Type_Name { get; private set; }
        public Movie? Movie { get; private set; }

        public Series? Series { get; private set; }
        public TvShows? TvShows { get; private set; }

        public MediaType()
        {

        }
        public MediaType(string mediatype)
        {
            this.Media_Type_Name = mediatype;
        }

    }
}
