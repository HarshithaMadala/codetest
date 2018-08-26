using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Models
{// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
 /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class meeting
    {

        private string dateField;

        private string meetingTypeField;

        private meetingTrack trackField;

        private uint meetingidField;

        private meetingRaces racesField;

        /// <remarks/>
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public string MeetingType
        {
            get
            {
                return this.meetingTypeField;
            }
            set
            {
                this.meetingTypeField = value;
            }
        }

        /// <remarks/>
        public meetingTrack track
        {
            get
            {
                return this.trackField;
            }
            set
            {
                this.trackField = value;
            }
        }

        /// <remarks/>
        public uint Meetingid
        {
            get
            {
                return this.meetingidField;
            }
            set
            {
                this.meetingidField = value;
            }
        }

        /// <remarks/>
        public meetingRaces races
        {
            get
            {
                return this.racesField;
            }
            set
            {
                this.racesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingTrack
    {

        private string nameField;

        private string translatedNameField;

        private string clubField;

        private string locationField;

        private string countryField;

        private string stateField;

        private string conditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TranslatedName
        {
            get
            {
                return this.translatedNameField;
            }
            set
            {
                this.translatedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string club
        {
            get
            {
                return this.clubField;
            }
            set
            {
                this.clubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRaces
    {

        private meetingRacesRace raceField;

        /// <remarks/>
        public meetingRacesRace race
        {
            get
            {
                return this.raceField;
            }
            set
            {
                this.raceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRace
    {

        private byte numberOfRunnersField;

        private string start_timeField;

        private meetingRacesRaceDistance distanceField;

        private meetingRacesRaceHorse[] horsesField;

        private meetingRacesRacePrices pricesField;

        private byte numberField;

        private string nameField;

        private uint idField;

        private string statusField;

        /// <remarks/>
        public byte NumberOfRunners
        {
            get
            {
                return this.numberOfRunnersField;
            }
            set
            {
                this.numberOfRunnersField = value;
            }
        }

        /// <remarks/>
        public string start_time
        {
            get
            {
                return this.start_timeField;
            }
            set
            {
                this.start_timeField = value;
            }
        }

        /// <remarks/>
        public meetingRacesRaceDistance distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("horse", IsNullable = false)]
        public meetingRacesRaceHorse[] horses
        {
            get
            {
                return this.horsesField;
            }
            set
            {
                this.horsesField = value;
            }
        }

        /// <remarks/>
        public meetingRacesRacePrices prices
        {
            get
            {
                return this.pricesField;
            }
            set
            {
                this.pricesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceDistance
    {

        private ushort metresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort metres
        {
            get
            {
                return this.metresField;
            }
            set
            {
                this.metresField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorse
    {

        private byte numberField;

        private meetingRacesRaceHorseTrainer trainerField;

        private string training_locationField;

        private string ownersField;

        private string coloursField;

        private string current_blinker_indField;

        private ushort prizemoney_wonField;

        private byte last_four_startsField;

        private bool last_four_startsFieldSpecified;

        private byte last_ten_startsField;

        private bool last_ten_startsFieldSpecified;

        private meetingRacesRaceHorseJockey jockeyField;

        private byte barrierField;

        private meetingRacesRaceHorseWeight weightField;

        private string nameField;

        private string countryField;

        private byte ageField;

        private string sexField;

        private string colourField;

        private string foaling_dateField;

        private uint idField;

        /// <remarks/>
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public meetingRacesRaceHorseTrainer trainer
        {
            get
            {
                return this.trainerField;
            }
            set
            {
                this.trainerField = value;
            }
        }

        /// <remarks/>
        public string training_location
        {
            get
            {
                return this.training_locationField;
            }
            set
            {
                this.training_locationField = value;
            }
        }

        /// <remarks/>
        public string owners
        {
            get
            {
                return this.ownersField;
            }
            set
            {
                this.ownersField = value;
            }
        }

        /// <remarks/>
        public string colours
        {
            get
            {
                return this.coloursField;
            }
            set
            {
                this.coloursField = value;
            }
        }

        /// <remarks/>
        public string current_blinker_ind
        {
            get
            {
                return this.current_blinker_indField;
            }
            set
            {
                this.current_blinker_indField = value;
            }
        }

        /// <remarks/>
        public ushort prizemoney_won
        {
            get
            {
                return this.prizemoney_wonField;
            }
            set
            {
                this.prizemoney_wonField = value;
            }
        }

        /// <remarks/>
        public byte last_four_starts
        {
            get
            {
                return this.last_four_startsField;
            }
            set
            {
                this.last_four_startsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool last_four_startsSpecified
        {
            get
            {
                return this.last_four_startsFieldSpecified;
            }
            set
            {
                this.last_four_startsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte last_ten_starts
        {
            get
            {
                return this.last_ten_startsField;
            }
            set
            {
                this.last_ten_startsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool last_ten_startsSpecified
        {
            get
            {
                return this.last_ten_startsFieldSpecified;
            }
            set
            {
                this.last_ten_startsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public meetingRacesRaceHorseJockey jockey
        {
            get
            {
                return this.jockeyField;
            }
            set
            {
                this.jockeyField = value;
            }
        }

        /// <remarks/>
        public byte barrier
        {
            get
            {
                return this.barrierField;
            }
            set
            {
                this.barrierField = value;
            }
        }

        /// <remarks/>
        public meetingRacesRaceHorseWeight weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string colour
        {
            get
            {
                return this.colourField;
            }
            set
            {
                this.colourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foaling_date
        {
            get
            {
                return this.foaling_dateField;
            }
            set
            {
                this.foaling_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseTrainer
    {

        private meetingRacesRaceHorseTrainerStatistics statisticsField;

        private string nameField;

        private ushort idField;

        /// <remarks/>
        public meetingRacesRaceHorseTrainerStatistics statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseTrainerStatistics
    {

        private meetingRacesRaceHorseTrainerStatisticsStatistic statisticField;

        /// <remarks/>
        public meetingRacesRaceHorseTrainerStatisticsStatistic statistic
        {
            get
            {
                return this.statisticField;
            }
            set
            {
                this.statisticField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseTrainerStatisticsStatistic
    {

        private string typeField;

        private ushort totalField;

        private byte firstsField;

        private byte secondsField;

        private byte thirdsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte firsts
        {
            get
            {
                return this.firstsField;
            }
            set
            {
                this.firstsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte seconds
        {
            get
            {
                return this.secondsField;
            }
            set
            {
                this.secondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte thirds
        {
            get
            {
                return this.thirdsField;
            }
            set
            {
                this.thirdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseJockey
    {

        private meetingRacesRaceHorseJockeyStatistics statisticsField;

        private string nameField;

        private ushort idField;

        /// <remarks/>
        public meetingRacesRaceHorseJockeyStatistics statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseJockeyStatistics
    {

        private meetingRacesRaceHorseJockeyStatisticsStatistic statisticField;

        /// <remarks/>
        public meetingRacesRaceHorseJockeyStatisticsStatistic statistic
        {
            get
            {
                return this.statisticField;
            }
            set
            {
                this.statisticField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseJockeyStatisticsStatistic
    {

        private string typeField;

        private ushort totalField;

        private byte firstsField;

        private byte secondsField;

        private byte thirdsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte firsts
        {
            get
            {
                return this.firstsField;
            }
            set
            {
                this.firstsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte seconds
        {
            get
            {
                return this.secondsField;
            }
            set
            {
                this.secondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte thirds
        {
            get
            {
                return this.thirdsField;
            }
            set
            {
                this.thirdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRaceHorseWeight
    {

        private byte allocatedField;

        private byte totalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte allocated
        {
            get
            {
                return this.allocatedField;
            }
            set
            {
                this.allocatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRacePrices
    {

        private meetingRacesRacePricesPrice priceField;

        /// <remarks/>
        public meetingRacesRacePricesPrice price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRacePricesPrice
    {

        private string priceTypeField;

        private meetingRacesRacePricesPriceHorse[] horsesField;

        /// <remarks/>
        public string priceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("horse", IsNullable = false)]
        public meetingRacesRacePricesPriceHorse[] horses
        {
            get
            {
                return this.horsesField;
            }
            set
            {
                this.horsesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meetingRacesRacePricesPriceHorse
    {

        private byte numberField;

        private decimal priceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }
}
