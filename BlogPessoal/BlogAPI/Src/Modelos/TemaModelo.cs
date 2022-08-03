﻿using System.ComponentModel.DataAnnotations;
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

    [Table("tb_temas")]
    public class Tema
    {
        #region Atributos


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Descricao { get; set; }

        [JsonIgnore, InverseProperty("Tema")]
        public List<Postagem> PostagensRelacionadas { get; set; }

        #endregion



    }
}