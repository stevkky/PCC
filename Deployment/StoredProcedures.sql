/*----------------------------------------------------------------------------------------------------------*/
/* Telligent (GH) Systems CodeGenerator (written by Stephen Adjei-Kyei.)                                   */
/*                                                                                                         */
/* File was generated using Telligent (GH) System's Code Generator.                                        */
/*                                                                                                         */
/* Date Generated: 7/7/2015 1:44:15 PM                                                                    */
/*                                                                                                         */
/* www.telligentgh.com                                                                                     */
/*---------------------------------------------------------------------------------------------------------*/
/*************************************************/
/* [dbo].Groups_INSERT */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_INSERT') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_INSERT
GO

CREATE PROCEDURE [dbo].Groups_INSERT
(
@groupName AS varchar(50) = null,
@parentGroupid AS int = null
)
AS

INSERT INTO
  [dbo].[groups]
(
  [group_name],
  [parent_groupid]
)
VALUES
(
  @groupName,
  @parentGroupid
)

SELECT SCOPE_IDENTITY()

GO

/*************************************************/
/* [dbo].Groups_SELECT */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_SELECT') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_SELECT
GO

CREATE PROCEDURE [dbo].Groups_SELECT
(
@no AS int
)
AS

SELECT
  *
FROM
  [dbo].[groups]
WHERE
  No = @no

GO

/*************************************************/
/* [dbo].Groups_UPDATE */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_UPDATE') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_UPDATE
GO

CREATE PROCEDURE [dbo].Groups_UPDATE
(
@no int = null,
@groupName varchar(50) = null,
@parentGroupid int = null
)
AS

UPDATE
  [dbo].[groups]
SET
  [group_name] = @groupName,
  [parent_groupid] = @parentGroupid
WHERE
  [No] = @no

GO

/*************************************************/
/* [dbo].Groups_DELETE */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_DELETE') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_DELETE
GO

CREATE PROCEDURE [dbo].Groups_DELETE
(
@no int
)
AS

DELETE
  [dbo].[groups]
WHERE
  [No] = @no

GO

/*************************************************/
/* [dbo].Groups_SEARCH */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_SEARCH') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_SEARCH
GO

CREATE PROCEDURE [dbo].Groups_SEARCH
(
@no int = null,
@groupName varchar(50) = null,
@parentGroupid int = null,
@ORDERBY_FIELD varchar(50) = 'parent_groupid'
)
AS

SELECT
  *
FROM
  [dbo].[groups]
WHERE
  (@no IS NULL OR [No] = @no)
AND
  (@groupName IS NULL OR @groupName = '' OR [group_name] LIKE @groupName + '%')
AND
  (@parentGroupid IS NULL OR [parent_groupid] = @parentGroupid)
ORDER BY CASE
WHEN lower(@ORDERBY_FIELD) = 'no' THEN  [No]
WHEN lower(@ORDERBY_FIELD) = 'group_name' THEN  [group_name]
WHEN lower(@ORDERBY_FIELD) = 'parent_groupid' THEN  [parent_groupid]
END ASC
GO

/*************************************************/
/* [dbo].Groups_SEARCHEXACT */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Groups_SEARCHEXACT') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].Groups_SEARCHEXACT
GO

CREATE PROCEDURE [dbo].Groups_SEARCHEXACT
(
@no int = null,
@groupName varchar(50) = null,
@parentGroupid int = null,
@ORDERBY_FIELD varchar(50) = 'parent_groupid'
)
AS

SELECT
  *
FROM
  [dbo].[groups]
WHERE
  (@no IS NULL OR [No] = @no)
AND
  (@groupName IS NULL OR @groupName = '' OR [group_name] = @groupName)
AND
  (@parentGroupid IS NULL OR [parent_groupid] = @parentGroupid)
ORDER BY CASE
WHEN lower(@ORDERBY_FIELD) = 'no' THEN  [No]
WHEN lower(@ORDERBY_FIELD) = 'group_name' THEN  [group_name]
WHEN lower(@ORDERBY_FIELD) = 'parent_groupid' THEN  [parent_groupid]
END ASC
GO

