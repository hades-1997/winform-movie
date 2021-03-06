USE [master]
GO
/****** Object:  Database [MovieC1810L]    Script Date: 12/4/2020 12:16:11 AM ******/
CREATE DATABASE [MovieC1810L]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieC1810L', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MovieC1810L.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieC1810L_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MovieC1810L_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MovieC1810L] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieC1810L].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieC1810L] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieC1810L] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieC1810L] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieC1810L] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieC1810L] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieC1810L] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MovieC1810L] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieC1810L] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieC1810L] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieC1810L] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieC1810L] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieC1810L] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieC1810L] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieC1810L] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieC1810L] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MovieC1810L] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieC1810L] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieC1810L] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieC1810L] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieC1810L] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieC1810L] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieC1810L] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieC1810L] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieC1810L] SET  MULTI_USER 
GO
ALTER DATABASE [MovieC1810L] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieC1810L] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieC1810L] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieC1810L] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieC1810L] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovieC1810L] SET QUERY_STORE = OFF
GO
USE [MovieC1810L]
GO
/****** Object:  Table [dbo].[account]    Script Date: 12/4/2020 12:16:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[acc_id] [int] IDENTITY(1,1) NOT NULL,
	[acc_user] [char](50) NOT NULL,
	[acc_password] [char](50) NOT NULL,
	[acc_authorization] [char](10) NOT NULL,
	[type] [char](2) NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[acc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[actor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actor](
	[act_id] [int] IDENTITY(1,1) NOT NULL,
	[act_fname] [char](20) NULL,
	[act_lname] [char](20) NULL,
	[act_gender] [char](1) NULL,
	[act_image] [char](50) NULL,
 CONSTRAINT [PK_actor] PRIMARY KEY CLUSTERED 
(
	[act_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[director]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[director](
	[dir_id] [int] IDENTITY(1,1) NOT NULL,
	[dir_fname] [char](20) NULL,
	[dir_lname] [char](20) NULL,
 CONSTRAINT [PK_director] PRIMARY KEY CLUSTERED 
(
	[dir_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genres]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genres](
	[gen_id] [int] IDENTITY(1,1) NOT NULL,
	[gen_title] [char](20) NULL,
 CONSTRAINT [PK_genres] PRIMARY KEY CLUSTERED 
(
	[gen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movie_cast]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_cast](
	[act_id] [int] NULL,
	[mov_id] [int] NULL,
	[role] [char](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movie_direction]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_direction](
	[dir_id] [int] NULL,
	[mov_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movie_genres]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_genres](
	[mov_id] [int] NULL,
	[gen_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movies]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[mov_id] [int] IDENTITY(1,1) NOT NULL,
	[mov_title] [char](50) NULL,
	[mov_year] [int] NULL,
	[mov_time] [int] NULL,
	[mov_lang] [char](50) NULL,
	[mov_dt_rel] [date] NULL,
	[mov_rel_country] [char](20) NULL,
 CONSTRAINT [PK_movies] PRIMARY KEY CLUSTERED 
(
	[mov_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rating]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rating](
	[mov_id] [int] NULL,
	[rev_id] [int] NULL,
	[rev_stars] [int] NULL,
	[num_o_ratings] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviewer]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviewer](
	[rev_id] [int] IDENTITY(1,1) NOT NULL,
	[rev_name] [char](30) NULL,
 CONSTRAINT [PK_reviewer] PRIMARY KEY CLUSTERED 
(
	[rev_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[movie_cast]  WITH CHECK ADD  CONSTRAINT [FK_movie_cast_actor] FOREIGN KEY([act_id])
REFERENCES [dbo].[actor] ([act_id])
GO
ALTER TABLE [dbo].[movie_cast] CHECK CONSTRAINT [FK_movie_cast_actor]
GO
ALTER TABLE [dbo].[movie_cast]  WITH CHECK ADD  CONSTRAINT [FK_movie_cast_movies] FOREIGN KEY([mov_id])
REFERENCES [dbo].[movies] ([mov_id])
GO
ALTER TABLE [dbo].[movie_cast] CHECK CONSTRAINT [FK_movie_cast_movies]
GO
ALTER TABLE [dbo].[movie_direction]  WITH CHECK ADD  CONSTRAINT [FK_movie_direction_director] FOREIGN KEY([dir_id])
REFERENCES [dbo].[director] ([dir_id])
GO
ALTER TABLE [dbo].[movie_direction] CHECK CONSTRAINT [FK_movie_direction_director]
GO
ALTER TABLE [dbo].[movie_direction]  WITH CHECK ADD  CONSTRAINT [FK_movie_direction_movies] FOREIGN KEY([mov_id])
REFERENCES [dbo].[movies] ([mov_id])
GO
ALTER TABLE [dbo].[movie_direction] CHECK CONSTRAINT [FK_movie_direction_movies]
GO
ALTER TABLE [dbo].[movie_genres]  WITH CHECK ADD  CONSTRAINT [FK_movie_genres_genres] FOREIGN KEY([gen_id])
REFERENCES [dbo].[genres] ([gen_id])
GO
ALTER TABLE [dbo].[movie_genres] CHECK CONSTRAINT [FK_movie_genres_genres]
GO
ALTER TABLE [dbo].[movie_genres]  WITH CHECK ADD  CONSTRAINT [FK_movie_genres_movies] FOREIGN KEY([mov_id])
REFERENCES [dbo].[movies] ([mov_id])
GO
ALTER TABLE [dbo].[movie_genres] CHECK CONSTRAINT [FK_movie_genres_movies]
GO
ALTER TABLE [dbo].[rating]  WITH CHECK ADD  CONSTRAINT [FK_rating_movies] FOREIGN KEY([mov_id])
REFERENCES [dbo].[movies] ([mov_id])
GO
ALTER TABLE [dbo].[rating] CHECK CONSTRAINT [FK_rating_movies]
GO
ALTER TABLE [dbo].[rating]  WITH CHECK ADD  CONSTRAINT [FK_rating_reviewer] FOREIGN KEY([rev_id])
REFERENCES [dbo].[reviewer] ([rev_id])
GO
ALTER TABLE [dbo].[rating] CHECK CONSTRAINT [FK_rating_reviewer]
GO
/****** Object:  StoredProcedure [dbo].[addMovie]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addMovie]
@mov_title char(50),
@mov_year integer,
@mov_time integer,
@mov_lang char(50),
@mov_dt_rel date,
@mov_rel_country char(5)
as

begin
	insert into movies(mov_title, mov_year,mov_time,mov_lang,mov_dt_rel,mov_rel_country) 
	values (@mov_title,@mov_year,@mov_time,@mov_lang,@mov_dt_rel,@mov_rel_country)
	-- kiem tra insert thanh cong hay that bai 
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[addReviews]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addReviews]
@rev_name char(30),
@mov_id int,
@rev_stars int
as
begin
	--select bang reviewr
	insert into reviewer(rev_name) values (@rev_name);
	-- insert into rating
	insert into rating (mov_id,rev_id,rev_stars,num_o_ratings) values (@mov_id,(select top (1) rev_id from reviewer order by rev_id desc),@rev_stars,1);
				-- kiem tra insert thanh cong hay that bai 
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[inserMovieCast]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inserMovieCast]
@act_id int
as 
begin
	insert into movie_cast(act_id,mov_id) values (@act_id, (select MAX(mov_id) from movies));
	-- kiem tra ket qua insert co thanh cong hay khong
	if @@ROWCOUNT > 0 begin return 1 end else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[insertActor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertActor]
@act_fname char(20),
@act_lname char(20),
@act_gender char(1)
as
begin
		insert into actor (act_fname,act_lname,act_gender) values (@act_fname,@act_lname,@act_gender)
	-- kiem tra insert thanh cong hay that bai 
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[insertDirector]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertDirector]
@dir_fname char(20),
@dir_lname char(20)
as
begin
	insert into director(dir_fname,dir_lname) values (@dir_fname,@dir_lname)

		-- kiem tra insert thanh cong hay that bai 
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[insertGenres]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--insert into genres
create proc [dbo].[insertGenres]
@gen_title char(20)
as
begin		
		insert into genres(gen_title) values (@gen_title)
			-- kiem tra insert thanh cong hay that bai 
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[insertMovieDirector]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertMovieDirector]
@dir_id int
as
begin
		insert into movie_direction(dir_id,mov_id) values (@dir_id,(select MAX(mov_id) from movies))
		--check ham insert thanh cong hay that bai 
		if @@ROWCOUNT > 0 begin return 1 end else begin return 0 end
end
GO
/****** Object:  StoredProcedure [dbo].[insertMovieGenres]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertMovieGenres]
@gen_id int
as 

begin
			insert into movie_genres (mov_id,gen_id) values ( (select MAX(mov_id) from movies ), @gen_id)
						-- kiem tra insert thanh cong hay that bai 
			IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[insertReviews]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertReviews]
@rev_name char(30)
as
begin
	--mov_id,mov_title,mov_dt_rel
	insert into reviewer(rev_name) values (@rev_name)
				-- kiem tra insert thanh cong hay that bai 
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END ELSE BEGIN RETURN 0 END
end
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Login] 
@acc_user char(50),
@acc_password char(50)
as
begin
	select * from account where acc_user=@acc_user and acc_password= @acc_password
end
GO
/****** Object:  StoredProcedure [dbo].[selectActor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectActor] -- tao procedure select toàn bộ danh sách Diễn Viên
	@tukhoa nvarchar(50) -- tìm kiếm sinh viên dựa trên từ khóa
	--1 : tìm theo mã Diễn Viên
	--2: tìm theo họ, tên đệm, tên
	--4: loại tìm kiếm: tương đối 
as
begin
	select act_id,
	act_fname,
	act_lname,
	case
		when act_gender = 0 then 'Nam' 
		else N'Nữ' 
		end as act_gender
		--- custom lại hiển thị giới tính. Nếu là 1: nam. Nếu là 0 thì nữ 
from actor
where
		LOWER(act_fname) like'%'+LOWER(trim(@tukhoa)) + '%'
		or LOWER(act_fname) like'%'+LOWER(trim(@tukhoa)) + '%'
		or LOWER(act_gender) like'%'+LOWER(trim(@tukhoa)) + '%'
	order by act_id;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllActor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllActor]-- tao procedure select toàn bộ danh sách sinh viên
as
begin
	select act_id,
	act_fname,
	act_lname,
	case
		when act_gender = 0 then 'Nam' 
		else N'Nữ' 
		end as act_gender
		--- custom lại hiển thị giới tính. Nếu là 1: nam. Nếu là 0 thì nữ 
	from actor
end
GO
/****** Object:  StoredProcedure [dbo].[selectAllReviews]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectAllReviews]

as
	select mov_id,mov_title,mov_dt_rel from movies
GO
/****** Object:  StoredProcedure [dbo].[SelectDirector]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectDirector]

As

Begin
		select * from director
End
GO
/****** Object:  StoredProcedure [dbo].[selectGenres]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectGenres]
as
begin
	select * from genres
end
GO
/****** Object:  StoredProcedure [dbo].[selectMovies]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectMovies]
as
begin
	select m.mov_title,mov_year,mov_time,mov_lang,mov_dt_rel,mov_rel_country,g.gen_title,d.dir_lname,a.act_lname from movies m 
			inner join movie_genres mn on m.mov_id = mn.mov_id
			inner join genres g on g.gen_id = mn.gen_id
			inner join movie_direction md on md.mov_id = m.mov_id
			inner join director d on d.dir_id = md.dir_id
			inner join movie_cast mc on m.mov_id = mc.mov_id
			inner join actor a on a.act_id = mc.act_id
end
GO
/****** Object:  StoredProcedure [dbo].[selectRating]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectRating]
as
	select m.mov_id,m.mov_title,rev.rev_name from rating  r
	inner join movies m on r.mov_id = m.mov_id
	inner join reviewer rev on r.rev_id = rev.rev_id
GO
/****** Object:  StoredProcedure [dbo].[selectTop1]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop1]
as
begin 
		select TOP 1(mov_id),mov_title,mov_dt_rel,mov_time from movies
end
GO
/****** Object:  StoredProcedure [dbo].[selectTop2]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop2]
as
begin 
		select mov_id,mov_title,mov_dt_rel,mov_time from movies where mov_id = 2
end
GO
/****** Object:  StoredProcedure [dbo].[selectTop3]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop3]
as
begin 
		select mov_id,mov_title,mov_dt_rel,mov_time from movies where mov_id = 3
end
GO
/****** Object:  StoredProcedure [dbo].[selectTop4]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop4]
as
begin 
		select mov_id,mov_title,mov_dt_rel,mov_time from movies where mov_id = 4
end
GO
/****** Object:  StoredProcedure [dbo].[selectTop5]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop5]
as
begin 
		select mov_id,mov_title,mov_dt_rel,mov_time from movies where mov_id = 5
end
GO
/****** Object:  StoredProcedure [dbo].[selectTop6]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectTop6]
as
begin 
		select mov_id,mov_title,mov_dt_rel,mov_time from movies where mov_id = 6
end
GO
/****** Object:  StoredProcedure [dbo].[selectUpdateActor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectUpdateActor]
@act_id int
as
begin
	select * from actor where act_id = @act_id
end
GO
/****** Object:  StoredProcedure [dbo].[updateActor]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateActor]
@act_fname char(20),
@act_lname char(20),
@act_gender char(1),
@act_id integer
as

begin
	update actor set 
	act_fname=@act_fname,
	act_lname=@act_lname,
	act_gender=@act_gender
	where 	act_id=@act_id
end
GO
/****** Object:  StoredProcedure [dbo].[updateDirector]    Script Date: 12/4/2020 12:16:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateDirector]
@dir_fname char(20),
@dir_lname char(20),
@dir_id integer
as
begin
	update director set 
	dir_fname= @dir_fname,
	dir_lname= @dir_lname
	where dir_id=@dir_id
end
GO
USE [master]
GO
ALTER DATABASE [MovieC1810L] SET  READ_WRITE 
GO
