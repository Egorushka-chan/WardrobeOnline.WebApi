﻿using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record SetDTO : IEntityDTO
    {
        // Пришлось сделать такой конструктор, потому конструктор в обьявлении записи сразу и поля создаёт
        public SetDTO(int iD, string name, string season, int physiqueID)
        {
            ID = iD;
            Name = name;
            Season = season;
            PhysiqueID = physiqueID;
        }

        public int ID { get; init; }
        public string Name { get; init; }
        public string? Description { get; init; }
        public string Season { get; init; }
        public int PhysiqueID { get; init; }
        public IReadOnlyList<int>? ClothIDs { get; init; }

        /// <summary>
        /// Это преобразование требует после себя обязательного определения Session/SessionID
        /// Требование использовать именно такой определитель
        /// И CastHelper не может помочь тут
        /// </summary>
        public static explicit operator Set(SetDTO self)
        {
            Set set = new()
            {
                ID = self.ID,
                Name = self.Name,
                Description = self.Description,
                PhysiqueID = self.PhysiqueID
            };
            return set;
        }

        //internal Set TranslateToDB(ITranslator translator)
        //{
        //    int id;
        //    if (translator.TryFindSeasonID(Season, out id))
        //    {
        //        Set set = new()
        //        {
        //            ID = ID,
        //            Name = Name,
        //            Description = Description,
        //            SeasonID = id,
        //            ComplectionID = ComplectionID
        //        };
        //        return set;
        //    }
        //    else
        //    {
        //        Set set = new()
        //        {
        //            ID = ID,
        //            Name = Name,
        //            Description = Description,
        //            Season = new Season() { Name = Season},
        //            ComplectionID = ComplectionID
        //        };
        //        return set;
        //    }
        //}
    }
}
