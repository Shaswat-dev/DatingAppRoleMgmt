using DatingApp.API.Models;
using DatingApp.API.WorkFlowModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        
        
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Request> Requests { get; set; }
        
        
        public DbSet<RequestAction> RequestActions { get; set; }
        public DbSet<Action> Actions { get; set; }

        public DbSet<ActionTarget> ActionTargets { get; set; }
        public DbSet<Process> Processs { get; set; }

        public DbSet<State> States { get; set; }
        
        
        public DbSet<StateType> StateTypes { get; set; }
        public DbSet<Transition> Transitions { get; set; }
        public DbSet<TransitionAction> TransitionActions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole => 
            {
               userRole.HasKey( ur => new {ur.UserId, ur.RoleId});

               userRole.HasOne(ur => ur.Role)
               .WithMany(r => r.UserRoles)
               .HasForeignKey(ur => ur.RoleId)
               .IsRequired();

               userRole.HasOne(ur => ur.User)
               .WithMany(r => r.UserRoles)
               .HasForeignKey(ur => ur.UserId)
               .IsRequired();
            });
            
            builder.Entity<Like>()
                .HasKey(k => new { k.LikerId, k.LikeeId });

            builder.Entity<Like>()
               .HasOne(u => u.Likee)
               .WithMany(u => u.Likers)
               .HasForeignKey(u => u.LikeeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
               .HasOne(u => u.Liker)
               .WithMany(u => u.Likees)
               .HasForeignKey(u => u.LikerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
              .HasOne(u => u.Sender)
              .WithMany(m => m.MessagesSent)
              .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
              .HasOne(u => u.Recipient)
              .WithMany(m => m.MessagesReceived)
              .OnDelete(DeleteBehavior.Restrict);


              builder.Entity<Request>(r => 
            {
              r.HasOne(u => u.CurrentState)
               .WithMany(u => u.Requests)
               .HasForeignKey(u => u.CurrentStateId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

                r.HasOne(u => u.User)
               .WithMany(u => u.Requests)
               .HasForeignKey(u => u.UserId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();
               
               r.HasOne(u => u.Process)
               .WithMany(u => u.Requests)
               .HasForeignKey(u => u.ProcessId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            });

            builder.Entity<State>(r => 
            {
              r.HasOne(u => u.Process)
               .WithMany(u => u.States)
               .HasForeignKey(u => u.ProcessId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

                r.HasOne(u => u.StateType)
               .WithMany(u => u.States)
               .HasForeignKey(u => u.StateTypeId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            });

            builder.Entity<Transition>(r => 
            {
              r.HasOne(u => u.CurrentState)
               .WithMany(u => u.Transitionnexts)
               .HasForeignKey(u => u.CurrentStateId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

                r.HasOne(u => u.NextState)
               .WithMany(u => u.Transitioncurrents)
               .HasForeignKey(u => u.NextStateId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

               r.HasOne(u => u.Process)
               .WithMany(u => u.Transitions)
               .HasForeignKey(u => u.ProcessId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            });

            builder.Entity<TransitionAction>( r =>
            {
                r.HasKey( u => new {u.TransitionId,u.ActionId});

                r.HasOne(ur => ur.Transition)
               .WithMany(r => r.TransititionActions)
               .HasForeignKey(ur => ur.TransitionId)
               .IsRequired();

               r.HasOne(ur => ur.Action)
               .WithMany(r => r.TransititionActions)
               .HasForeignKey(ur => ur.ActionId)
               .IsRequired();
            });

            builder.Entity<ActionTarget>( r =>
            {
                r.HasOne(ur => ur.Action)
               .WithMany(r => r.ActionTargets)
               .HasForeignKey(ur => ur.ActionId)
               .IsRequired();

            });

            builder.Entity<RequestAction>( r =>
            {
                r.HasOne(ur => ur.Request)
               .WithMany(r => r.RequestActions)
               .HasForeignKey(ur => ur.RequestId)
               .IsRequired();

                r.HasOne(ur => ur.Action)
               .WithMany(r => r.RequestActions)
               .HasForeignKey(ur => ur.ActionId)
               .IsRequired();

               r.HasOne(ur => ur.Transition)
               .WithMany(r => r.RequestActions)
               .HasForeignKey(ur => ur.TransitionId)
               .IsRequired();

            });
        }
    }
}