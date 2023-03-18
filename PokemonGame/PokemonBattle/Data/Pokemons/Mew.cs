using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mew : Pokemon
	{
		public override string Name => "Mew";
		public override List<Ability> AvailableAbilities => new() {new Synchronize() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Reflecttype() },
			[10] = new List<Move>() { new Amnesia() },
			[20] = new List<Move>() { new Batonpass() },
			[30] = new List<Move>() { new Ancientpower() },
			[40] = new List<Move>() { new Lifedew() },
			[50] = new List<Move>() { new Nastyplot() },
			[60] = new List<Move>() { new Metronome() },
			[70] = new List<Move>() { new Imprison() },
			[80] = new List<Move>() { new Transform() },
			[90] = new List<Move>() { new Aurasphere() },
			[100] = new List<Move>() { new Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Allyswitch(), new Amnesia(), new Assurance(), new Attract(), new Aurasphere(), new Avalanche(), new Batonpass(), new Beatup(), new Blazekick(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bounce(), new Bravebird(), new Breakingswipe(), new Brickbreak(), new Brine(), new Brutalswing(), new Bugbuzz(), new Bulkup(), new Bulldoze(), new Bulletseed(), new Burningjealousy(), new Calmmind(), new Chargebeam(), new Charm(), new Closecombat(), new Coaching(), new Corrosivegas(), new Cosmicpower(), new Crosspoison(), new Crunch(), new Cut(), new Darkestlariat(), new Darkpulse(), new Dazzlinggleam(), new Defog(), new Dig(), new Dive(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Drillrun(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Explosion(), new Facade(), new Faketears(), new Falseswipe(), new Fireblast(), new Firefang(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Flash(), new Flashcannon(), new Fling(), new Flipturn(), new Fly(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Foulplay(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Guardswap(), new Gunkshot(), new Gyroball(), new Hail(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Helpinghand(), new Hex(), new Hiddenpower(), new Highhorsepower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icefang(), new Icepunch(), new Iciclespear(), new Icywind(), new Imprison(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Leafblade(), new Leafstorm(), new Leechlife(), new Lightscreen(), new Liquidation(), new Lowkick(), new Lowsweep(), new Magicalleaf(), new Magicroom(), new Megahorn(), new Megakick(), new Megapunch(), new Meteorbeam(), new Metronome(), new Mistyexplosion(), new Mistyterrain(), new Muddywater(), new Mudshot(), new Mysticalfire(), new Nastyplot(), new Outrage(), new Overheat(), new Payback(), new Payday(), new Phantomforce(), new Pinmissile(), new Playrough(), new Pluck(), new Poisonjab(), new Pollenpuff(), new Poltergeist(), new Powergem(), new Powerswap(), new Powerwhip(), new Protect(), new Psychic(), new Psychicfangs(), new Psychicterrain(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Razorshell(), new Recycle(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Risingvoltage(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Scald(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Screech(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Smartstrike(), new Snarl(), new Snore(), new Solarbeam(), new Solarblade(), new Speedswap(), new Spikes(), new Stealthrock(), new Steelroller(), new Steelwing(), new Stompingtantrum(), new Stoneedge(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Tailslap(), new Taunt(), new Terrainpulse(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Torment(), new Toxic(), new Toxicspikes(), new Triattack(), new Trick(), new Trickroom(), new Tripleaxel(), new Uproar(), new Uturn(), new Venomdrench(), new Venoshock(), new Voltswitch(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Wildcharge(), new Willowisp(), new Wonderroom(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 40;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}