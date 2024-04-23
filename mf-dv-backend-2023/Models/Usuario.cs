﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dv_backend_2023.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha")]
        [DataType(DataType.Password)]   
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha")]
        public Perfil Perfil { get; set; }

    }
    public enum Perfil
    {
        Admin,
        User
    }




}
