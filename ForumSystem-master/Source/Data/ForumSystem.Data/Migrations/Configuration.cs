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
                Title = "Господ беше българин, но отдавна го отказахме",
                Content = "Отказахме го, защото тъпчем на едно място и не искаме и грам да се развиваме. И ако преди някакви си десетина години се смеехме на клубни отбори от Беларус и Кипър например, и ги биехме на футбол за „добро утро“, тези страни отдавна дръпнаха спрямо своите възможности. Даже и на ниво национални отбори. А ние си седим на нашето ниво. На дъното.",
                Tags = new List<Tag>
                {
                    new Tag() { Name = "Футбол" },
                    new Tag() { Name = "Господ" },
                    new Tag() { Name = "Некадърници" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Овен",
                Content = " В четвъртък ще се почувствате като омагьосани от вашата половинка. Не забравяйте, че всеки може да сгреши, затова не гледайте през цялото време през розови очила, а бъдете реалисти.",
                Tags = new List<Tag>
                {
                    new Tag() { Name = "Чеверме" },
                    new Tag() { Name = "Овен" },
                    new Tag() { Name = "Зодиак" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Телец",
                Content = " Бъдете внимателни в това как тълкувате посланията, които ви изпраща отсрещната страна. Те могат да бъдат смесени.",
                Tags = new List<Tag>
                {
                      new Tag() { Name = "Тас кебап" },
                    new Tag() { Name = "Телец" },
                   new Tag() { Name = "Зодиак" }
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Близнаци",
                Content = " Любовта пристига при вас като една еуфория. Разграничете работата от личните ангажименти и се наслаждавайте на романтиката.",
                Tags = new List<Tag>
                {
                       new Tag(){Name = "Оппа"},
                    new Tag(){Name = "Близнаци"},
                   new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Рак",
                Content = "Без значение дали са обвързани или не, за някои от представителите на зодия Рак ще настъпи романтичен период. Възможно е тази романтика да е провокирана от ваш колега. Ще се почувствате така, сякаш сте сродни души. И все пак не гледайте на ситуацията идеалистично, особено ако офис политиката не ви позволява да имате флирт на работното място.",
                Tags = new List<Tag>
                {
                      new Tag(){Name = "Глупости"},
                    new Tag(){Name = "Рак"},
                   new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Лъв",
                Content = " През тази седмица Лъвовете ще кипят от желание за секс. Ако нямате сексуален партньор, периодът е подходящ да намерите такъв. В случай, че вече сте го открили, сексуалното желание може да прерасне в дълбоки и истински чувства.",
                Tags = new List<Tag>
                {
                      new Tag(){Name = "Нумерология"},
                    new Tag(){Name = "Лъв"},
                   new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Дева",
                Content = "Романтика ще има и при Девите. За тези от вас, които имат половинка до себе си, настъпва период, в който може да започнете с плановете за общо бъдеще. Не е изключено роднина да опита да попречи на вашето щастие. Не позволявайте това да наруши хармонията между вас.",
                Tags = new List<Tag>
                {
                       new Tag(){Name = "Зодии"},
                    new Tag(){Name = "Дева"},
                   new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Везни",
                Content = "Ако в сектора на любовта се чувствате развълнувани или наранени от любим човек, запазете емоциите за себе си и не ги споделяйте с колеги. Това може да бъде причина за появата на офис клюки. На по-късен етап ще се радвате, че сте запазили любовните си истории само за себе си. Ако търсите нова любов, периодът е подходящ да я срещнете.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "Зодии"},
                    new Tag(){Name = "Везни"},
                   new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Скорпион",
                Content = " За тези от вас, които имат половинка до себе си е добре да разграничат финансите от романтиката. Възможно е любимият човек да има желание към определена придобивка, която не влиза във вашите финансови планове и това да стане повод за скандал. Бъдете внимателни и въпреки несъгласието си, не наранявайте любимия човек.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "Зодии"},
                    new Tag(){Name = "Скорпион"},
                    new Tag(){Name = "Зодиак"}
                }
            };
            context.Posts.Add(post);

            post = new Post()
            {
                Title = "Любовен хороскоп за 17-23 ноември 2014 - Стрелец",
                Content = " При обвързаните Стрелци може да се появи някой, който ще се опита да ги убеди, че любовта им с партньора не е това, от което се нуждаят. Не обръщайте внимание и се отдайте на романтика и любов. За тези от вас, които нямат любим човек, има шанс да срещнат някой, който да се окаже тяхната сродна душа.",
                Tags = new List<Tag>
                {
                    new Tag(){Name = "Зодии"},
                    new Tag(){Name = "Стрелец"},
                    new Tag(){Name = "Зодиак"}
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
