<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>XSLT преобразование</title>
			</head>
			<body>
				<h1>XSLT преобразование</h1>
				
					<ol>
						<li>
							Имя сотрудника:
							<xsl:value-of select="Data/CardDocument/MainInfo/@FirstName"/>
						</li>
						<li>
							Должность:
							<xsl:value-of select="Data/CardDocument/Performers/PerformersRow/@Performer"/>
						</li>
						
						<li>
							Дата регистрации:
							<xsl:value-of select="Data/CardDocument/MainInfo/@RegDate"/>
						</li>
						<li>
							Тема:
							<xsl:value-of select="Data/CardDocument/MainInfo/@Content"/>
						</li>
						<li>
							Ссылка на карточку:
							<xsl:value-of select="Data/CardDocument/MainInfo/@ReferenceList"/>
						</li>
						<li>
							ИД автора:
							<xsl:value-of select="Data/CardDocument/MainInfo/@Author"/>
						</li>
					</ol>			
				<hr/>
			<h2>Performer к нормальному виду</h2>	
			<table>
				<tr>
					<td>Должность: </td>
					<td><xsl:value-of select="Data/RefStaff/Units/UnitsRow/UnitsRow/UnitsRow/Employees/EmployeesRow/@PositionName"/></td>
				</tr>
			</table>
			
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>