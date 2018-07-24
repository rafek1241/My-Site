using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class PersonalInformation
    {
        public long PersonalInformationId { get; set; }

        public string Description { get; set; }

        public virtual Person Person { get; set; }

        /// <summary>
        /// Twitter, fb, github, linkedin etc..
        /// </summary>
        public virtual ICollection<ThirdPartyApp> ThirdPartyApps { get; set; }

        /// <summary>
        /// Recent work places and position on them
        /// </summary>
        public virtual ICollection<Experience> ExperienceCollection { get; set; }

        /// <summary>
        /// Recent education was made
        /// </summary>
        public virtual ICollection<Education> EducationCollection { get; set; }

        /// <summary>
        /// List of known skills
        /// </summary>
        public virtual ICollection<Skill> Skills { get; set; }

        /// <summary>
        /// List of certificates which I have
        /// </summary>
        public virtual ICollection<Certificate> Certifications { get; set; }

        /// <summary>
        /// List of awards
        /// </summary>
        public virtual ICollection<Award> Awards { get; set; }

        /// <summary>
        /// List of hobbies
        /// </summary>
        public virtual ICollection<Hobby> Hobbies { get; set; }

        /// <summary>
        /// People what you admire (if there is any)
        /// </summary>
        public virtual ICollection<AdmiredPerson> AdmiredPeople { get; set; }

        /// <summary>
        /// List of recommendations
        /// </summary>
        public virtual ICollection<Recommendation> Recommendations { get; set; }

        /// <summary>
        /// List of courses
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }

        /// <summary>
        /// List of publications/articles/posts what I want to share.
        /// </summary>
        public virtual ICollection<Publication> Publications { get; set; }

        /// <summary>
        /// Language skills
        /// </summary>
        public virtual ICollection<LanguageSkill> LanguageSkills { get; set; }
    }
}
