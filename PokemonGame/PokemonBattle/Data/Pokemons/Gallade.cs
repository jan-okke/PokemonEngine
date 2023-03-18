using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gallade : Pokemon
	{
		public override string Name => "Gallade";
		public override List<Ability> AvailableAbilities => new() {new Steadfast() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(68, 125, 65, 65, 115, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Nightslash(), new Growl(), new Disarmingvoice(), new Hypnosis(), new Drainingkiss(), new Imprison(), new Psybeam(), new Lifedew(), new Charm(), new Calmmind(), new Psychic(), new Dreameater(), new Futuresight(), new Leer(), new Furycutter(), new Doubleteam(), new Confusion() },
			[9] = new List<Move>() { new Helpinghand() },
			[12] = new List<Move>() { new Feint() },
			[15] = new List<Move>() { new Teleport() },
			[18] = new List<Move>() { new Aerialace() },
			[23] = new List<Move>() { new Falseswipe() },
			[28] = new List<Move>() { new Protect() },
			[35] = new List<Move>() { new Swordsdance() },
			[42] = new List<Move>() { new Psychocut() },
			[49] = new List<Move>() { new Healpulse() },
			[56] = new List<Move>() { new Quickguard(), new Wideguard() },
			[63] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Allyswitch(), new Attract(), new Aurasphere(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Charm(), new Closecombat(), new Coaching(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Earthquake(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Falseswipe(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Icywind(), new Imprison(), new Leafblade(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magicalleaf(), new Magicroom(), new Megakick(), new Megapunch(), new Mistyterrain(), new Poisonjab(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarblade(), new Stoneedge(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Tripleaxel(), new Willowisp(), new Wonderroom(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 520;
		public override int ExpYield => 259;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}