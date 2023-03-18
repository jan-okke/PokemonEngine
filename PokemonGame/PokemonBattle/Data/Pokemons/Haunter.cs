using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Haunter : Pokemon
	{
		public override string Name => "Haunter";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(45, 50, 45, 115, 55, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Shadowpunch() },
			[1] = new List<Move>() { new Shadowpunch(), new Lick(), new Confuseray(), new Hypnosis(), new Meanlook() },
			[12] = new List<Move>() { new Payback() },
			[16] = new List<Move>() { new Spite() },
			[20] = new List<Move>() { new Curse() },
			[24] = new List<Move>() { new Hex() },
			[30] = new List<Move>() { new Nightshade() },
			[36] = new List<Move>() { new Suckerpunch() },
			[42] = new List<Move>() { new Darkpulse() },
			[48] = new List<Move>() { new Shadowball() },
			[54] = new List<Move>() { new Destinybond() },
			[60] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Corrosivegas(), new Darkpulse(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Firepunch(), new Fling(), new Foulplay(), new Gigadrain(), new Hex(), new Hiddenpower(), new Icepunch(), new Icywind(), new Payback(), new Poisonjab(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Round(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Shadowclaw(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Toxic(), new Trick(), new Trickroom(), new Uproar(), new Venoshock(), new Willowisp(), new Wonderroom() };
		public override int Weight => 1;
		public override int ExpYield => 142;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}