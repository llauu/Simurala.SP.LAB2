﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Jugador : Persona{
        private string? nombre;
        private string? apellido;
        private string? usuario;
        private bool partidaEnCurso;
        private int puntaje;

        public string Nombre { get => nombre!; set => nombre = value; }
        public string Apellido { get => apellido!; set => apellido = value; }
        public string Usuario { get => usuario!; set => usuario = value; }
        public bool PartidaEnCurso { get => partidaEnCurso; set => partidaEnCurso = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        private Jugador() {
            this.puntaje = 0;
            this.partidaEnCurso = false;
        }

        public Jugador(string nombre, string apellido, string usuario) : this() {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2) {
            return jugador1.usuario == jugador2.usuario;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2) {
            return !(jugador1 == jugador2);
        }

        public override string ToString() {
            return $"{this.usuario}";
        }
    }
}
