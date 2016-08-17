



DECLARE @ProjectBinary as varbinary(max)
DECLARE @operation_id as bigint
Set @ProjectBinary = (SELECT * FROM OPENROWSET(BULK 'F:\study\SSISDEMO\SSISDEMO\SSISDEMO\bin\Development\SSISDEMO.ispac', SINGLE_BLOB) as BinaryData)

Exec catalog.deploy_project @folder_name = 'SSISPackages', @project_name = 'SSISDEMO', @Project_Stream = @ProjectBinary, @operation_id = @operation_id out

-------------------------------------------------------------------------------------

Declare @execution_id bigint
EXEC [SSISDB].[catalog].[create_execution] @package_name=N'Package.dtsx', @execution_id=@execution_id OUTPUT, @folder_name=N'SSISPackages', @project_name=N'SSISDEMO', @use32bitruntime=False, @reference_id=1

Select @execution_id
DECLARE @var0 smallint = 3
EXEC [SSISDB].[catalog].[set_execution_parameter_value] @execution_id,  @object_type=50, @parameter_name=N'LOGGING_LEVEL', @parameter_value=@var0

DECLARE @var1 int = 1
EXEC [SSISDB].[catalog].[set_execution_parameter_value] @execution_id,  @object_type=30, @parameter_name=N'Parameter1', @parameter_value=@var1

GO
