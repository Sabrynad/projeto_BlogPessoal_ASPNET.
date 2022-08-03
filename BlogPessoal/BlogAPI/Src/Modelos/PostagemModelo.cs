using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogAPI.Src.Modelos
{
 /// <summary>
 /// <para>Resumo: Classe responsavel por representar tb_temas no banco.</para>
 /// <para>Criado por: Sabryna</para>
 /// <para>Versão: 1.0</para>
 /// <para>Data: 03/08/2022</para>
 /// </summary>
 

    [Table("tb_postagens")]
    public class Postagem
    {
        #region Atributos


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Foto { get; set; }


        [ForeignKey("fk_criador")]
        public Usuario Criador { get; set; }

        [ForeignKey("fk_tema")]
        public Tema Tema { get; set; }

        #endregion
    }
}

