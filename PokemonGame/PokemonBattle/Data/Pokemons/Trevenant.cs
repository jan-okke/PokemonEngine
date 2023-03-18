using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Trevenant : Pokemon
	{
		public override string Name => "Trevenant";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Harvest() };
		public override Stats BaseStats => new Stats(85, 110, 76, 65, 82, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Shadowclaw() },
			[1] = new List<Move>() { new Shadowclaw(), new Astonish(), new Tackle(), new Branchpoke(), new Leechseed() },
			[12] = new List<Move>() { new Confuseray() },
			[16] = new List<Move>() { new Willowisp() },
			[20] = new List<Move>() { new Hex() },
			[24] = new List<Move>() { new Growth() },
			[28] = new List<Move>() { new Hornleech() },
			[32] = new List<Move>() { new Curse() },
			[36] = new List<Move>() { new Phantomforce() },
			[40] = new List<Move>() { new Ingrain() },
			[44] = new List<Move>() { new Woodhammer() },
			[48] = new List<Move>() { new Destinybond() },
			[52] = new List<Move>() { new Forestscurse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Brutalswing(), new Bulldoze(), new Calmmind(), new Darkpulse(), new Dig(), new Drainpunch(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Focusblast(), new Foulplay(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Leafstorm(), new Magicalleaf(), new Phantomforce(), new Poisonjab(), new Poltergeist(), new Protect(), new Psychic(), new Reflect(), new Rest(), new Rockslide(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thief(), new Trick(), new Trickroom(), new Venomdrench(), new Willowisp(), new Xscissor() };
		public override int Weight => 710;
		public override int ExpYield => 166;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}