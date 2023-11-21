export interface Welcome {
    kind: string;
    data: WelcomeData;
}

export interface WelcomeData {
    after:      string;
    dist:       number;
    modhash:    string;
    geo_filter: null;
    children:   Child[];
    before:     null;
}

export interface Child {
    kind: Kind;
    data: ChildData;
}

export interface ChildData {
    approved_at_utc:               null;
    subreddit:                     Subreddit;
    selftext:                      string;
    author_fullname:               string;
    saved:                         boolean;
    mod_reason_title:              null;
    gilded:                        number;
    clicked:                       boolean;
    title:                         string;
    link_flair_richtext:           FlairRichtext[];
    subreddit_name_prefixed:       SubredditNamePrefixed;
    hidden:                        boolean;
    pwls:                          number;
    link_flair_css_class:          LinkFlairCSSClass | null;
    downs:                         number;
    thumbnail_height:              number | null;
    top_awarded_type:              null;
    hide_score:                    boolean;
    name:                          string;
    quarantine:                    boolean;
    link_flair_text_color:         FlairTextColor | null;
    upvote_ratio:                  number;
    author_flair_background_color: null | string;
    subreddit_type:                SubredditType;
    ups:                           number;
    total_awards_received:         number;
    media_embed:                   Gildings;
    thumbnail_width:               number | null;
    author_flair_template_id:      null | string;
    is_original_content:           boolean;
    user_reports:                  any[];
    secure_media:                  Media | null;
    is_reddit_media_domain:        boolean;
    is_meta:                       boolean;
    category:                      null;
    secure_media_embed:            Gildings;
    link_flair_text:               null | string;
    can_mod_post:                  boolean;
    score:                         number;
    approved_by:                   null;
    is_created_from_ads_ui:        boolean;
    author_premium:                boolean;
    thumbnail:                     string;
    edited:                        boolean;
    author_flair_css_class:        null;
    author_flair_richtext:         FlairRichtext[];
    gildings:                      Gildings;
    content_categories:            null;
    is_self:                       boolean;
    mod_note:                      null;
    created:                       number;
    link_flair_type:               AuthorFlairType;
    wls:                           number;
    removed_by_category:           null;
    banned_by:                     null;
    author_flair_type:             AuthorFlairType;
    domain:                        Domain;
    allow_live_comments:           boolean;
    selftext_html:                 null | string;
    likes:                         null;
    suggested_sort:                null;
    banned_at_utc:                 null;
    view_count:                    null;
    archived:                      boolean;
    no_follow:                     boolean;
    is_crosspostable:              boolean;
    pinned:                        boolean;
    over_18:                       boolean;
    all_awardings:                 any[];
    awarders:                      any[];
    media_only:                    boolean;
    link_flair_template_id?:       string;
    can_gild:                      boolean;
    spoiler:                       boolean;
    locked:                        boolean;
    author_flair_text:             null | string;
    treatment_tags:                any[];
    visited:                       boolean;
    removed_by:                    null;
    num_reports:                   null;
    distinguished:                 null;
    subreddit_id:                  SubredditID;
    author_is_blocked:             boolean;
    mod_reason_by:                 null;
    removal_reason:                null;
    link_flair_background_color:   LinkFlairBackgroundColor | null;
    id:                            string;
    is_robot_indexable:            boolean;
    report_reasons:                null;
    author:                        string;
    discussion_type:               null;
    num_comments:                  number;
    send_replies:                  boolean;
    whitelist_status:              WhitelistStatus;
    contest_mode:                  boolean;
    mod_reports:                   any[];
    author_patreon_flair:          boolean;
    author_flair_text_color:       FlairTextColor | null;
    permalink:                     string;
    parent_whitelist_status:       WhitelistStatus;
    stickied:                      boolean;
    url:                           string;
    subreddit_subscribers:         number;
    created_utc:                   number;
    num_crossposts:                number;
    media:                         Media | null;
    is_video:                      boolean;
    post_hint?:                    PostHint;
    url_overridden_by_dest?:       string;
    preview?:                      Preview;
    is_gallery?:                   boolean;
    media_metadata?:               { [key: string]: MediaMetadatum };
    gallery_data?:                 GalleryData;
}

export interface FlairRichtext {
    e: AuthorFlairType;
    t: string;
}

export enum AuthorFlairType {
    Richtext = "richtext",
    Text = "text",
}

export enum FlairTextColor {
    Dark = "dark",
}

export enum Domain {
    IReddIt = "i.redd.it",
    RedditCOM = "reddit.com",
    SelfAww = "self.aww",
    VReddIt = "v.redd.it",
}

export interface GalleryData {
    items: Item[];
}

export interface Item {
    media_id: string;
    id:       number;
}

export interface Gildings {
}

export enum LinkFlairBackgroundColor {
    Empty = "",
    Ffd635 = "#ffd635",
}

export enum LinkFlairCSSClass {
    Empty = "",
    Lc = "lc",
}

export interface Media {
    reddit_video: RedditVideo;
}

export interface RedditVideo {
    bitrate_kbps:       number;
    fallback_url:       string;
    has_audio:          boolean;
    height:             number;
    width:              number;
    scrubber_media_url: string;
    dash_url:           string;
    duration:           number;
    hls_url:            string;
    is_gif:             boolean;
    transcoding_status: TranscodingStatus;
}

export enum TranscodingStatus {
    Completed = "completed",
}

export interface MediaMetadatum {
    status: Status;
    e:      E;
    m:      M;
    p:      S[];
    s:      S;
    id:     string;
}

export enum E {
    Image = "Image",
}

export enum M {
    ImageJpg = "image/jpg",
}

export interface S {
    y: number;
    x: number;
    u: string;
}

export enum Status {
    Valid = "valid",
}

export enum WhitelistStatus {
    AllAds = "all_ads",
}

export enum PostHint {
    HostedVideo = "hosted:video",
    Image = "image",
}

export interface Preview {
    images:  Image[];
    enabled: boolean;
}

export interface Image {
    source:      Source;
    resolutions: Source[];
    variants:    Gildings;
    id:          string;
}

export interface Source {
    url:    string;
    width:  number;
    height: number;
}

export enum Subreddit {
    Aww = "aww",
}

export enum SubredditID {
    T52Qh1O = "t5_2qh1o",
}

export enum SubredditNamePrefixed {
    RAww = "r/aww",
}

export enum SubredditType {
    Public = "public",
}

export enum Kind {
    T3 = "t3",
}
