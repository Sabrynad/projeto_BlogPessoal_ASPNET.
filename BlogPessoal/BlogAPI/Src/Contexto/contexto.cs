using BlogAPI.Src.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Src.Contexto
{
    /// <summary>
    /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definirDbSets</para>
    /// <para>Criado por: Sabryna</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 03/08/2022</para>
    /// </summary>

    public class BlogPessoalContexto : DbContext
    {
        #region Atributos

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Postagem> Postagens { get; set; }

        #endregion

        #region Construtores

        public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt): base(opt) { }


        #endregion
    }
}
