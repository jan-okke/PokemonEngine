using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vespiquen : Pokemon
	{
		public override string Name => "Vespiquen";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(70, 80, 102, 80, 102, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Strugglebug(), new Bugbite(), new Sweetscent(), new Gust(), new Poisonsting(), new Confuseray() },
			[4] = new List<Move>() { new Furycutter() },
			[8] = new List<Move>() { new Aromaticmist() },
			[12] = new List<Move>() { new Fellstinger() },
			[16] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Swagger() },
			[24] = new List<Move>() { new Aromatherapy() },
			[28] = new List<Move>() { new Airslash() },
			[32] = new List<Move>() { new Powergem() },
			[36] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Attackorder(), new Defendorder() },
			[44] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Airslash(), new Assurance(), new Attract(), new Beatup(), new Bugbuzz(), new Crosspoison(), new Cut(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Flash(), new Fling(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Pinmissile(), new Powergem(), new Protect(), new Raindance(), new Rest(), new Revenge(), new Reversal(), new Roost(), new Round(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Toxic(), new Toxicspikes(), new Uproar(), new Uturn(), new Venoshock(), new Xscissor() };
		public override int Weight => 385;
		public override int ExpYield => 166;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}