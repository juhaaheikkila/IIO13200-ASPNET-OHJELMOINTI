<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <h2>Palautteet</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th>pvm</th>
        <th>tekija</th>
        <th>opittu</th>
        <th>haluan oppia</th>
        <th>hyvää</th>
        <th>parannettavaa</th>
        <th>muuta</th>
      </tr>
      <xsl:for-each select="palautteet/palaute">
        <tr>
          <td>
            <xsl:value-of select="pvm"/>
          </td>
          <td>
            <xsl:value-of select="tekija"/>
          </td>
          <td>
            <xsl:value-of select="opittu"/>
          </td>
          <td>
            <xsl:value-of select="haluanoppia"/>
          </td>
          <td>
            <xsl:value-of select="hyvaa"/>
          </td>
          <td>
            <xsl:value-of select="parannettavaa"/>
          </td>
          <td>
            <xsl:value-of select="muuta"/>
          </td>
        </tr>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>
