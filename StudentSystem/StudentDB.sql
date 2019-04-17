
/*==============================================================*/
/* Table: Score                                                 */
/*==============================================================*/
create table Score
(
   id                   int not null,
   StudentID            int,
   CourseID             int,
   Score                int,
   primary key (id)
);

/*==============================================================*/
/* Table: Student                                               */
/*==============================================================*/
create table Student
(
   id                   int not null auto_increment,
   `name`                 varchar(20),
   primary key (id)
);

alter table Score add constraint FK_Reference_1 foreign key (CocoursecoursecoursecoursecoursecourseurseID)
      references Course (id) on delete restrict on update restrict;

alter table Score add constraint FK_Reference_2 foreign key (StudentID)
      references Student (id) on delete restrict on update restrict;
