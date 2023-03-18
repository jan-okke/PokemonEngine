using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mimejr : Pokemon
	{
		public override string Name => "Mime Jr.";
		public override List<Ability> AvailableAbilities => new() {new Soundproof(), new Filter() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(20, 25, 45, 70, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Copycat() },
			[4] = new List<Move>() { new Batonpass() },
			[8] = new List<Move>() { new Encore() },
			[12] = new List<Move>() { new Confusion() },
			[16] = new List<Move>() { new Roleplay() },
			[20] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Recycle() },
			[28] = new List<Move>() { new Psybeam() },
			[32] = new List<Move>() { new Mimic() },
			[36] = new List<Move>() { new Lightscreen(), new Reflect(), new Safeguard() },
			[40] = new List<Move>() { new Suckerpunch() },
			[44] = new List<Move>() { new Dazzlinggleam() },
			[48] = new List<Move>() { new Psychic() },
			[52] = new List<Move>() { new Teeterdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Brickbreak(), new Calmmind(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Futuresight(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Icywind(), new Lightscreen(), new Magicroom(), new Mistyterrain(), new Nastyplot(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Uproar(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Confuseray(), new Fakeout(), new Futuresight(), new Healingwish(), new Hypnosis(), new Icywind(), new Magicroom(), new Mimic(), new Powersplit(), new Teeterdance(), new Tickle(), new Trick() };
		public override int Weight => 130;
		public override int ExpYield => 62;
		public override int CatchRate => 145;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}