﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_APP1_IS2_HistoriasClinicas
{
    public class Consultorio
    {
        //todas las historias
        public Historias2[] listado_historia()
        {
            using (var ctx = new ClinicaHistoriaEntities())
            {
                var lst = from d in ctx.HISTORIAS
                          select d;

                Historias2[] r = new Historias2[lst.Count()];
                int i = 0;
                foreach (var d in lst)
                {
                    r[i++] = new Historias2
                    {
                        PADRE_H = d.PADRE_H,
                        MADRE_H = d.MADRE_H,
                        FALLECIDO_P_H = d.FALLECIDO_P_H,
                        FALLECIDO_M_H = d.FALLECIDO_M_H,
                        CAUSAS_P_H = d.CAUSAS_P_H,
                        CAUSAS_M_H = d.CAUSAS_M_H,
                        NUM_H_H = d.NUM_H_H,
                        VIVO_H_H = d.VIVO_H_H,
                        MUERTE_H_H = d.MUERTE_H_H,
                        CAUSAS_H_H = d.CAUSAS_H_H,
                        SON_H = d.SON_H,
                        VIVO_SON_H = d.VIVO_SON_H,
                        MUERTOS_SON_H = d.MUERTOS_SON_H,
                        CAUSAS_SON_H = d.CAUSAS_SON_H,
                        ALCOHOL_H = d.ALCOHOL_H,
                        TABACO_H = d.TABACO_H,
                        DROGAS_H = d.DROGAS_H,
                        FRECUENCIA_TAB_H = d.FRECUENCIA_TAB_H,
                        FRECUENCIA_ALC_H = d.FRECUENCIA_ALC_H,
                        FRECUENCIA_DRO_H = d.FRECUENCIA_DRO_H,
                        ALIMENTACION_H = d.ALIMENTACION_H,
                        DIPSIA_H = d.DIPSIA_H,
                        PARADIPSIA = d.PARADIPSIA,
                        FRECUENCIA_PARADIPSIA = d.FRECUENCIA_PARADIPSIA,
                        INSOMNIO_H = d.INSOMNIO_H,
                        FRECUENCIA_INSOM_H = d.FRECUENCIA_INSOM_H,
                        OTRO_H = d.OTRO_H,
                        ID_H = d.ID_H,
                    };
                }
                return r;
            }
        }
        //consultar una sola historia
        public Historias2 una_historia(int ID_H)
        {
            using (var ctx = new ClinicaHistoriaEntities())
            {
                var d = ctx.HISTORIAS.Find(ID_H);
                Historias2 r = null;
                if (d != null)
                {
                    r = new Historias2
                    {
                        PADRE_H = d.PADRE_H,
                        MADRE_H = d.MADRE_H,
                        FALLECIDO_P_H = d.FALLECIDO_P_H,
                        FALLECIDO_M_H = d.FALLECIDO_M_H,
                        CAUSAS_P_H = d.CAUSAS_P_H,
                        CAUSAS_M_H = d.CAUSAS_M_H,
                        NUM_H_H = d.NUM_H_H,
                        VIVO_H_H = d.VIVO_H_H,
                        MUERTE_H_H = d.MUERTE_H_H,
                        CAUSAS_H_H = d.CAUSAS_H_H,
                        SON_H = d.SON_H,
                        VIVO_SON_H = d.VIVO_SON_H,
                        MUERTOS_SON_H = d.MUERTOS_SON_H,
                        CAUSAS_SON_H = d.CAUSAS_SON_H,
                        ALCOHOL_H = d.ALCOHOL_H,
                        TABACO_H = d.TABACO_H,
                        DROGAS_H = d.DROGAS_H,
                        FRECUENCIA_TAB_H = d.FRECUENCIA_TAB_H,
                        FRECUENCIA_ALC_H = d.FRECUENCIA_ALC_H,
                        FRECUENCIA_DRO_H = d.FRECUENCIA_DRO_H,
                        ALIMENTACION_H = d.ALIMENTACION_H,
                        DIPSIA_H = d.DIPSIA_H,
                        PARADIPSIA = d.PARADIPSIA,
                        FRECUENCIA_PARADIPSIA = d.FRECUENCIA_PARADIPSIA,
                        INSOMNIO_H = d.INSOMNIO_H,
                        FRECUENCIA_INSOM_H = d.FRECUENCIA_INSOM_H,
                        OTRO_H = d.OTRO_H,
                        ID_H = d.ID_H,
                    };
                }
                return r;
            }
        }
        //insertar historia clinica
        public int insertar_historia(string PADRE_H, string MADRE_H, string FALLECIDO_P_H,
                        string FALLECIDO_M_H, string CAUSAS_P_H, string CAUSAS_M_H, int NUM_H_H,
                        int VIVO_H_H, int MUERTE_H_H, string CAUSAS_H_H, int SON_H, int VIVO_SON_H,
                        int MUERTOS_SON_H, string CAUSAS_SON_H, string ALCOHOL_H, string TABACO_H,
                        string DROGAS_H, string FRECUENCIA_TAB_H, string FRECUENCIA_ALC_H, string FRECUENCIA_DRO_H,
                        string ALIMENTACION_H, string DIPSIA_H, string PARADIPSIA, string FRECUENCIA_PARADIPSIA,
                        string INSOMNIO_H, string FRECUENCIA_INSOM_H, string OTRO_H, int ID_H)
        {
            using (var ctx = new ClinicaHistoriaEntities())
            {
                var d = new HISTORIAS();
                d.PADRE_H = PADRE_H;
                d.MADRE_H = MADRE_H;
                d.FALLECIDO_P_H = FALLECIDO_P_H;
                d.FALLECIDO_M_H = FALLECIDO_M_H;
                d.CAUSAS_P_H = CAUSAS_P_H;
                d.CAUSAS_M_H = CAUSAS_M_H;
                d.NUM_H_H = NUM_H_H;
                d.VIVO_H_H = VIVO_H_H;
                d.MUERTE_H_H = MUERTE_H_H;
                d.CAUSAS_H_H = CAUSAS_H_H;
                d.SON_H = SON_H;
                d.VIVO_SON_H = VIVO_SON_H;
                d.MUERTOS_SON_H = MUERTOS_SON_H;
                d.CAUSAS_SON_H = CAUSAS_SON_H;
                d.ALCOHOL_H = ALCOHOL_H;
                d.TABACO_H = TABACO_H;
                d.DROGAS_H = DROGAS_H;
                d.FRECUENCIA_TAB_H = FRECUENCIA_TAB_H;
                d.FRECUENCIA_ALC_H = FRECUENCIA_ALC_H;
                d.FRECUENCIA_DRO_H = FRECUENCIA_DRO_H;
                d.ALIMENTACION_H = ALIMENTACION_H;
                d.DIPSIA_H = DIPSIA_H;
                d.PARADIPSIA = PARADIPSIA;
                d.FRECUENCIA_PARADIPSIA = FRECUENCIA_PARADIPSIA;
                d.INSOMNIO_H = INSOMNIO_H;
                d.FRECUENCIA_INSOM_H = FRECUENCIA_INSOM_H;
                d.OTRO_H = OTRO_H;

                ctx.HISTORIAS.Add(d);
                ctx.SaveChanges();
            }
            return 0;
        }
    }
}
