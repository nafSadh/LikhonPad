namespace ns7.bhaswor
{
    public class BanglaBorno
    {
        
        #region Bangla Borno Prokarved
        public enum 
            tothyo
        {
            __NULL = 0,
            SUCHONApoint = 0x0980,
            SOMAPTIpoint = 0x0A00,
            _forceKar = 0x9ff
        }
        public enum 
            Swor
        {
            _NULL = 0,
            _sworShuru = 0x0984,
            o ,
            a,
            i,
            ii,
            u,
            uu,
            RI, LI, r01, r02,
            e,
            OI, r03, r04,
            oa,
            ow,
            _sworShesh,
            ae = 0x09CF
        }
        public enum 
            Byanzon
        {
            _NULL = 0,
            k = 0x0995, kh, g, gh, uno,
            c, ch, z, zh, nio,
            T, Th, D, Dh, N,
            t, th, d, dh, n, r05,
            p, ph, b, bh, m,
            j,
            r, r06,
            l, r07, r08, r09,
            sh, ss, s, h, r10, r11, nukta,
            R = 0x09DC, Rh, r28,
            y,
            t_ = 0x09CE,
            _chondrobindu = 0x0981, _anuswor, _bisorgo
        }
        public enum 
            Kar
        {
            _NULL = 0,
            //swor + 56 = kar
            kaarnatok = 0x09BD,

            a,
            i,
            ii,
            u,
            uu,
            RI, RII, r12, r13,
            e,
            OI, r14, r15,
            oa,
            ow,
            hosonto
        }
        public enum 
            Onko 
        {
            _NULL = 0,
            shunno = 0x09E6, ek, dui, tin, car, panc, choy, sat, at, noy
        }
        #endregion

        #region Chihno
        /// <summary>
        /// Bengali UNICODE characters
        /// Range 0980-09FF
        /// </summary>
        public enum Chihno 
        {
            _shunnodoirghoBicchinno = 0x200C,
            _odourgoJukti,
            _nbsp = 0x00A0,
            _NULL = 0,
            banglaUnicodeShuru = 0x0980,
            chondrobindu,
            onuswor,
            bisorgo, _001,

            swor_O,
            swor_A,
            hroswo_I,
            diirgho_II,
            hroswo_U,
            diirgo_UU,
            RI, LI, _002, _003,
            E,
            OI, _004, _005,
            Oa,
            OW,

            konthyo_oghoass_olpopran,
            konthyo_oghoass_mohapran,
            konthyo_ghoass_olpopran,
            konthyo_ghoass_mohapran,
            konthyo_nasikyo,

            talobyo_oghoass_olpopran,
            talobyo_oghoass_mohapran,
            talobyo_ghoass_olpopran,
            talobyo_ghoass_mohapran,
            talobyo_nasikyo,

            muurdhonyo_oghoass_olpopran,
            muurdhonyo_oghoass_mohapran,
            muurdhonyo_ghoass_olpopran,
            muurdhonyo_ghoass_mohapran,
            muurdhonyo_nasikyo,

            dontyo_oghoass_olpopran,
            dontyo_oghoass_mohapran,
            dontyo_ghoass_olpopran,
            dontyo_ghoass_mohapran,
            dontyo_nasikyo, _006,


            owsstho_oghoass_olpopran,
            owsstho_oghoass_mohapran,
            owsstho_ghoass_olpopran,
            owsstho_ghoass_mohapran,
            owsstho_nasikyo,

            ontostho_jo,
            komponjat_ghoss_swolpopran_ro, _007,
            parshwik_ghoss_swolpopran_lo, _008, _009, _00a,

            talobyo_shis,
            muurdhonyo_shis,
            dontyo_shis,
            mohapran_shis, _00b, _00c,

            nukta,
            obogroho,

            a_kar,
            hroswo_i_kar,
            diirgo_ii_kar,
            hroswo_u_kar,
            diirgo_uu_kar,
            ri_kar, ri_dirgho_kar, _00d, _00e,
            e_kar,
            oi_kar, _00f, _010,
            oa_kar,
            ow_kar,

            hosonto,

            khohdo_to,
            _011, _012, _013, _014, _015, _016, _017, _018,
            ow_kar_anupod, _019, _01a, _01b, _01c,

            tarronjat_olpopran_R,
            tarronjat_mohapran_Rh, _01d,
            ontostho_yo,

            RI_dirgho, LI_dirgo, LI_kar, LI_dirgho_kar,
            _01e, _01f,

            shunno,
            ek,
            dui,
            tin,
            car,
            panc,
            choy,
            sat,
            at,
            noy,

            ohomia_ro,
            ohomia_roro,

            tonka,
            taka,
            mudra1, mudra2, mudra3, mudra4,
            mudra_1, mudra16, iswor, _020, _021, _022, _023,

            banglaUnicodeShesh,
            _forceKar = 0x9FF
        }
        #endregion
        #region toChihno
        public static Chihno toChihno(Swor x)
        {
            return (Chihno)x;
        }
        public static Chihno toChihno(Byanzon x)
        {
            return (Chihno)x;
        }
        public static Chihno toChihno(Kar x)
        {
            return (Chihno)x;
        }
        public static Chihno toChihno(Onko x)
        {
            return (Chihno)x;
        }
        public static Chihno toChihno(char x)
        {
            return (Chihno)x;
        }
        #endregion

        #region Methods
        public static Kar SworToKar(Swor x)
        {
            if (Swor._sworShuru < x && x > Swor._sworShesh)
                return (Kar)(x + 56);
            else
                return (Kar)x;
        }
        public static Chihno SworToKar(Chihno x)
        {
            if( ((int)Swor._sworShuru < (int)x) && ((int)x < (int)Swor._sworShesh) )
                return (Chihno)(x + 56);
            else
                return (Chihno)x;
        }
        public static Swor KarToSwor(Kar x)
        {
            return (Swor)(x - 56);
        }

        public static Byanzon toMohapran(Byanzon x)
        {
            return (Byanzon)(x + 1);
        }
        public static Chihno toMohapran(Chihno x)
        {
            return (Chihno)(x + 1);
        }
        public static Chihno toMohapranChihno(Byanzon x)
        {
            return (Chihno)(x + 1);
        }
        public static Chihno toMohapranChihno(Chihno x)
        {
            return (Chihno)(x + 1);
        }

        public static Byanzon toOlpopran(Byanzon x)
        {
            return (Byanzon)(x - 1);
        }
        public static Chihno toOlpopran(Chihno x)
        {
            return (Chihno)(x - 1);
        }
        public static Chihno toOlpopranChihno(Byanzon x)
        {
            return (Chihno)(x - 1);
        }
        public static Chihno toOlpopranChihno(Chihno x)
        {
            return (Chihno)(x - 1);
        }
        #endregion
    }
}