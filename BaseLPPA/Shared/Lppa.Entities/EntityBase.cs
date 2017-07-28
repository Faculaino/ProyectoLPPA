using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Lppa.Entities
{
    /// <summary>
    /// Base entity class.
    /// </summary>
    [DataContract]
    public class EntityBase : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        
        [Browsable(false)]
        public int ID { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            return this.GetType().Name + ": " +
                string.Join("|", this.GetType().GetProperties()
                .Where(p => !p.PropertyType.IsGenericType && !p.PropertyType.IsArray)
                .Select(p => string.Format("{0}={1}", p.Name, p.GetValue(this, null))));
        }

        #region Implementing audit Pattern

     
        public DateTime CreatedOn { get; set; }
     
        public string CreatedBy { get; set; }
     
        public DateTime ChangedOn { get; set; }
    
        public string ChangedBy { get; set; }

      
        #endregion

    }
}
