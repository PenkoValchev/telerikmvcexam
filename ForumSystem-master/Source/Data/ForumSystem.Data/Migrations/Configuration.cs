namespace ForumSystem.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ForumSystem.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        private UserManager<ApplicationUser> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        public void SeedUsers(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            this.userManager.Create(new ApplicationUser() { Email = "Master@master.com", UserName = "Master" }, "123456");
            this.userManager.Create(new ApplicationUser() { Email = "monster@monster.com", UserName = "Monster" }, "123456");
            this.userManager.Create(new ApplicationUser() { Email = "BabaGicka@gicka.com", UserName = "BabaTi" }, "123456");
            this.userManager.Create(new ApplicationUser() { Email = "vreme_za_kupon@grave.com", UserName = "CreepMaster" }, "123456");
            this.userManager.Create(new ApplicationUser() { Email = "Kroki@krokodilka.me", UserName = "Kroki" }, "123456");
        }

        public void SeedPosts(ApplicationDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            var post = new Post()
            {
                Title = "������ ���� ��������, �� ������� �� ���������",
                Content = "��������� ��, ������ ������ �� ���� ����� � �� ������ � ���� �� �� ���������. � ��� ����� ������� �� �������� ������ �� ������� �� ������ ������ �� ������� � ����� ��������, � �� ������ �� ������ �� ������ ����, ���� ������ ������� �������� ������ ������ �����������. ���� � �� ���� ���������� ������. � ��� �� ����� �� ������ ����. �� ������.",
                Tags = new List<Tag>
                {
                    new Tag() { Name = "������" },
                    new Tag() { Name = "������" },
                    new Tag() { Name = "�����������" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ����",
                Content = " � ��������� �� �� ����������� ���� ���������� �� ������ ���������. �� ����������, �� ����� ���� �� ������, ������ �� �������� ���� ������ ����� ���� ������ �����, � ������ ��������.",
                Tags = new List<Tag>
                {
                    new Tag() { Name = "�������" },
                    new Tag() { Name = "����" },
                    new Tag() { Name = "������" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - �����",
                Content = " ������ ���������� � ���� ��� ��������� ����������, ����� �� ������� ���������� ������. �� ����� �� ����� �������.",
                Tags = new List<Tag>
                {
                      new Tag() { Name = "��� �����" },
                    new Tag() { Name = "�����" },
                   new Tag() { Name = "������" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ��������",
                Content = " ������� �������� ��� ��� ���� ���� �������. ������������ �������� �� ������� ����������� � �� ������������� �� �����������.",
                Tags = new List<Tag>
                {
                       new Tag(){Name = "����"},
                    new Tag(){Name = "��������"},
                   new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ���",
                Content = "��� �������� ���� �� ��������� ��� ��, �� ����� �� ��������������� �� ����� ��� �� ������� ���������� ������. �������� � ���� ��������� �� � ����������� �� ��� ������. �� �� ����������� ����, ����� ��� ������ ����. � ��� ��� �� �������� �� ���������� ������������, ������� ��� ���� ���������� �� �� ��������� �� ����� ����� �� ��������� �����.",
                Tags = new List<Tag>
                {
                      new Tag(){Name = "��������"},
                    new Tag(){Name = "���"},
                   new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ���",
                Content = " ���� ���� ������� �������� �� ����� �� ������� �� ����. ��� ������ ��������� ��������, �������� � �������� �� �������� �����. � ������, �� ���� ��� �� �������, ����������� ������� ���� �� �������� � ������� � �������� �������.",
                Tags = new List<Tag>
                {
                      new Tag(){Name = "�����������"},
                    new Tag(){Name = "���"},
                   new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ����",
                Content = "��������� �� ��� � ��� ������. �� ���� �� ���, ����� ���� ��������� �� ���� ��, �������� ������, � ����� ���� �� ��������� � ��������� �� ���� ������. �� � ��������� ������� �� ����� �� ������� �� ������ ������. �� ������������ ���� �� ������ ���������� ����� ���.",
                Tags = new List<Tag>
                {
                       new Tag(){Name = "�����"},
                    new Tag(){Name = "����"},
                   new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - �����",
                Content = "��� � ������� �� ������� �� ��������� ������������ ��� �������� �� ����� �����, �������� �������� �� ���� �� � �� �� ���������� � ������. ���� ���� �� ���� ������� �� ������� �� ���� �����. �� ��-����� ���� �� �� �������, �� ��� �������� ��������� �� ������� ���� �� ���� ��. ��� ������� ���� �����, �������� � �������� �� � ��������.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "�����"},
                    new Tag(){Name = "�����"},
                   new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - ��������",
                Content = " �� ���� �� ���, ����� ���� ��������� �� ���� �� � ����� �� ����������� ��������� �� �����������. �������� � �������� ����� �� ��� ������� ��� ���������� ����������, ����� �� ����� ��� ������ ��������� ������� � ���� �� ����� ����� �� �������. ������ ���������� � ������� ������������ ��, �� ����������� ������� �����.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "�����"},
                    new Tag(){Name = "��������"},
                    new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "������� �������� �� 17-23 ������� 2014 - �������",
                Content = " ��� ����������� ������� ���� �� �� ����� �����, ����� �� �� ����� �� �� �����, �� ������� �� � ��������� �� � ����, �� ����� �� �������. �� ��������� �������� � �� ������� �� ��������� � �����. �� ���� �� ���, ����� ����� ����� �����, ��� ���� �� ������� �����, ����� �� �� ����� ������� ������ ����.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "�����"},
                    new Tag(){Name = "�������"},
                    new Tag(){Name = "������"}
                }
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }

        protected override void Seed(ApplicationDbContext context)
        {
            this.userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            this.SeedUsers(context);
            this.SeedPosts(context);
        }
    }
}
