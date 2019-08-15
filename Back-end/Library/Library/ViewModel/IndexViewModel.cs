using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModel
{
    public class IndexViewModel
    {
        public  List<AdminUser> AdminUsers { get; set; }
        public List<BlogHeader> BlogHeaders { get; set; }
        public List<AllReleas> AllReleas { get; set; }
        public List<BlogInfo> BlogInfos { get; set; }
        public List<Book> Books { get; set; }
        public List<BookCategory> BookCategories { get; set; }
        public List<BooksMediaTitle> BooksMediaTitles { get; set; }
        public List<Community> Communities { get; set; }
        public List<LibraryWelcome> LibraryWelcomes { get; set; }
        public List<Logo> Logos { get; set; }
        public List<NewReleas> NewReleas { get; set; }
        public List<NewsEvent> NewsEvents { get; set; }
        public List<Offering> Offerings { get; set; }
        public List<OnOrderItem> OnOrderItems { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<RelatedEvent> RelatedEvents { get; set; }
        public List<RelatedSearch> RelatedSearches { get; set; }
        public List<ServicesWho> ServicesWhos { get; set; }
        public List<Setting> Settings { get; set; }
        public List<SliderRoot> SliderRoots { get; set; }
        public List<StaffPick> StaffPicks { get; set; }
        public List<WordsCommunity> WordsCommunities { get; set; }
        public List<ContactHeader> ContactHeaders { get; set; }
        public List<ContactPhone> ContactPhones { get; set; }

    }
}