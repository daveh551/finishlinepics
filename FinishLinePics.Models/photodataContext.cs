using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FinishLinePics.Models.Entities.Mapping;
using FinishLinePics.Models.Entities;

namespace FinishLinePics.Models
{
    public partial class photodataContext : DbContext
    {
        static photodataContext()
        {
            Database.SetInitializer<photodataContext>(null);
        }

        public photodataContext()
            : base("Name=photodataContext")
        {
        }

        //public DbSet<AspNetRole> AspNetRoles { get; set; }
        //public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Photographer> Photographers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //public DbSet<UserProfile> UserProfiles { get; set; }
        //public DbSet<webpages_Membership> webpages_Membership { get; set; }
        //public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        //public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new AspNetRoleMap());
            //modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            //modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            //modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new DistanceMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new PhotographerMap());
            modelBuilder.Configurations.Add(new PhotoMap());
            //modelBuilder.Configurations.Add(new UserProfileMap());
            //modelBuilder.Configurations.Add(new webpages_MembershipMap());
            //modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            //modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
