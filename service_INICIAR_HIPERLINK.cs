using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace PainelPRONIM
{
    public class service_INICIAR_HIPERLINK
    {
        public service_INICIAR_HIPERLINK()
        {

        }

        public static void Abrir(string produto, MOD_Tabela_XML modelo_XML)
        {
            try
            {
                string diretorio = null;

                #region SUPRIMENTOS
                if ("TP_NET".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.TP_NET_LINK;
                    Process.Start(diretorio);
                }
                else if ("OP_NET".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.OP_NET_LINK;
                    Process.Start(diretorio);
                }
                #endregion

                // FINANCEIRO

                // TRIBUTARIO

                // PESSOAL

                #region SOCIAL
                else if ("SP_WEB".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.SP_WEB_LINK;
                    Process.Start(diretorio);
                }
                else if ("LG_NET".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.LG_NET_LINK;
                    Process.Start(diretorio);
                }
                else if ("TL_NET".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.TL_NET_LINK;
                    Process.Start(diretorio);
                }
                #endregion

                #region GOVCORP
                else if ("TB".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.TB_LINK;
                    Process.Start(diretorio);
                }
                else if ("CIDADE_MOB".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.CIDADE_MOB_LINK;
                    Process.Start(diretorio);
                }
                else if ("TB_NET".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.TB_NET_LINK;
                    Process.Start(diretorio);
                }
                #endregion

                #region SISTEMAS EXTERNOS
                else if ("HOMEPAGE_LICITACON_TCE_RS".Equals(produto))
                {
                    diretorio = @"http://www1.tce.rs.gov.br/portal/page/portal/tcers/jurisdicionados/sistemas_controle_externo/licitacon/apresentacao";
                    Process.Start(diretorio);
                }
                else if ("HOMEPAGE_LICITACON_CIDADAO_TCE_RS".Equals(produto))
                {
                    diretorio = @"http://www1.tce.rs.gov.br/aplicprod/f?p=50500:1::::::";
                    Process.Start(diretorio);
                }
                #endregion

                #region BOTOES SUPERIORES
                else if ("CETIL_PAINEL_SOLICITACOES".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.GOVBR_PAINEL_SOLICITACOES_LINK;
                    Process.Start(diretorio);
                }
                else if ("DUETO_SIGA".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.DUETO_SIGA_LINK;
                    Process.Start(diretorio);
                }
                else if ("DUETO_SOSOFT_CONEXOES".Equals(produto))
                {
                    diretorio = @"" + modelo_XML.DUETO_SOSOFT_CONEXOES_LINK;
                    Process.Start(diretorio);
                }
                #endregion
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\nAs possiveis causas podem ser: O caminho do diretório PRONIM esta errado. A pasta da aplicação esta errada. " +
                                                          "O nome do executável da aplicação não existe ou foi alterada sua descrição.", "Erro ao tentar abrir aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
