using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Shared.Models;
using MySite.Shared.Models.About;

namespace MySite.Client.Base.Component
{
    public class AboutBase : BlazorComponent
    {
        public PersonalInformation PersonalInformation { get; set; }

        /// <summary>
        /// Twitter, fb, github, linkedin etc..
        /// </summary>
        public ThirdPartyApp[] ThirdPartyApps { get; set; }

        /// <summary>
        /// Recent work places and position on them
        /// </summary>
        public Experience[] ExperienceCollection { get; set; }

        /// <summary>
        /// Recent education was made
        /// </summary>
        public Education[] EducationCollection { get; set; }

        /// <summary>
        /// List of known skills
        /// </summary>
        public Skill[] Skills { get; set; }

        /// <summary>
        /// List of certificates which I have
        /// </summary>
        public Certificate[] Certifications { get; set; }

        /// <summary>
        /// List of awards
        /// </summary>
        public Award[] Awards { get; set; }

        /// <summary>
        /// List of hobbies
        /// </summary>
        public Hobby[] Hobbies { get; set; }

        /// <summary>
        /// People what you admire (if there is any)
        /// </summary>
        public AdmiredPerson[] AdmiredPeople { get; set; }

        /// <summary>
        /// List of recommendations
        /// </summary>
        public Recommendation[] Recommendations { get; set; }

        /// <summary>
        /// List of courses
        /// </summary>
        public Course[] Courses { get; set; }

        /// <summary>
        /// List of publications/articles/posts what I want to share.
        /// </summary>
        public Publication[] Publications { get; set; }

        /// <summary>
        /// Language skills
        /// </summary>
        public LanguageSkill[] LanguageSkills { get; set; }
    }
}
