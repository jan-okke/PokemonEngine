using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mew : Pokemon
{
	public override string Name => "Mew";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize() };
	public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Reflecttype() },
		[10] = new List<Move>() { new Moves.Amnesia() },
		[20] = new List<Move>() { new Moves.Batonpass() },
		[30] = new List<Move>() { new Moves.Ancientpower() },
		[40] = new List<Move>() { new Moves.Lifedew() },
		[50] = new List<Move>() { new Moves.Nastyplot() },
		[60] = new List<Move>() { new Moves.Metronome() },
		[70] = new List<Move>() { new Moves.Imprison() },
		[80] = new List<Move>() { new Moves.Transform() },
		[90] = new List<Move>() { new Moves.Aurasphere() },
		[100] = new List<Move>() { new Moves.Psychic() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Avalanche(), new Moves.Batonpass(), new Moves.Beatup(), new Moves.Blazekick(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Bravebird(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Corrosivegas(), new Moves.Cosmicpower(), new Moves.Crosspoison(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Defog(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Drillrun(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Explosion(), new Moves.Facade(), new Moves.Faketears(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Flipturn(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Guardswap(), new Moves.Gunkshot(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Megahorn(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Payday(), new Moves.Phantomforce(), new Moves.Pinmissile(), new Moves.Playrough(), new Moves.Pluck(), new Moves.Poisonjab(), new Moves.Pollenpuff(), new Moves.Poltergeist(), new Moves.Powergem(), new Moves.Powerswap(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicfangs(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Smartstrike(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Speedswap(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Steelwing(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Tailslap(), new Moves.Taunt(), new Moves.Terrainpulse(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Voltswitch(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 40;
	public override int ExpYield => 300;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}